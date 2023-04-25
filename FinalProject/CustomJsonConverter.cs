using System;
using System.Collections.Generic;
using System.Drawing;
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
        // I have no idea how to convert the Bitmap into text and I feel like storing every byte into an array might get
        // long... instead I'm thinking that when we deserialize the .json file, we simply create a template bitmap and
        // assign recreate it using the .gif images we've been saving.
        public override void WriteJson(JsonWriter writer, Bitmap value, JsonSerializer serializer)
        {
            writer.WriteValue("bitmap:)");
        }

        public override Bitmap ReadJson(JsonReader reader, Type objecType, Bitmap existingValue, bool hasExistingValue,
            JsonSerializer serializer)
        {
            return new Bitmap(480, 480);
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
