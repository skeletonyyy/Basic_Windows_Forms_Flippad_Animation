using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace FinalProject
{
    // This was possible thanks to the Newtonsoft documentation. The custom converters' documentation can be
    // found here: https://www.newtonsoft.com/json/help/html/CustomJsonConverterGeneric.htm

    public class SizeConverter : JsonConverter<Size>
    {
        public override void WriteJson(JsonWriter writer, Size value, JsonSerializer serializer)
        {
            writer.WriteValue($"{value.Width},{value.Height}");
        }

        public override Size ReadJson(JsonReader reader, Type objecType, Size existingValue, bool hasExistingValue,
            JsonSerializer serializer)
        {
            string str = (string)reader.Value;
            var strArr = str.Split(',');
            return new Size(int.Parse(strArr[0]), int.Parse(strArr[1]));
        }
    }

    public class BitmapConverter : JsonConverter<Bitmap>
    {
        public override void WriteJson(JsonWriter writer, Bitmap value, JsonSerializer serializer)
        {
            byte[] byteArr;
            using (var ms = new MemoryStream())
            {
                value.Save(ms, ImageFormat.Gif);
                byteArr = ms.ToArray();
            }

            string str = "";
            for (var i = 0; i < byteArr.Length; i++)
            {
                str += $"{byteArr[i]}/";
            }

            str = str.Remove(str.Length - 1);
            writer.WriteValue(str);
        }

        public override Bitmap ReadJson(JsonReader reader, Type objecType, Bitmap existingValue, bool hasExistingValue,
            JsonSerializer serializer)
        {
            // Bitmap conversion by Mike Perrenoud: https://stackoverflow.com/questions/21555394/how-to-create-bitmap-from-byte-array
            string str = (string)reader.Value;
            string[] strArr = str.Split('/');
            byte[] byteArr = new byte[strArr.Length];
            for (int i = 0; i < strArr.Length; i++)
            {
                byteArr[i] = byte.Parse(strArr[i]);
            }
            Bitmap bitmap;
            using (var ms = new MemoryStream(byteArr))
            {
                bitmap = new Bitmap(ms);
            }
            return new Bitmap(bitmap);
        }
    }

    public class ColorConverter : JsonConverter<Color>
    {
        public override void WriteJson(JsonWriter writer, Color value, JsonSerializer serializer)
        {
            writer.WriteValue(value.ToArgb().ToString());
        }

        public override Color ReadJson(JsonReader reader, Type objecType, Color existingValue, bool hasExistingValue,
            JsonSerializer serializer)
        {
            string argb = (string)reader.Value;
            return Color.FromArgb(int.Parse(argb));
        }
    }

    public class PointConverter : JsonConverter<Point>
    {
        public override void WriteJson(JsonWriter writer, Point value, JsonSerializer serializer)
        {
            writer.WriteValue($"{value.X},{value.Y}");
        }

        public override Point ReadJson(JsonReader reader, Type objecType, Point existingValue, bool hasExistingValue,
            JsonSerializer serializer)
        {
            string str = (string)reader.Value;
            var strArr = str.Split(',');
            return new Point(int.Parse(strArr[0]), int.Parse(strArr[1]));
        }
    }
}
