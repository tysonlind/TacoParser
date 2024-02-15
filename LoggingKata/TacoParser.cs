using System.Runtime;

namespace LoggingKata
{
    /// <summary>
    /// Parses a POI file to locate all the Taco Bells
    /// </summary>
    public class TacoParser
    {
        readonly ILog logger = new TacoLogger();
        
        public ITrackable Parse(string line)
        {
            logger.LogInfo("Begin parsing");

            // Take your line and use line.Split(',') to split it up into an array of strings, separated by the char ','
            var cells = line.Split(',');

            // If your array's Length is less than 3, something went wrong
            if (cells.Length < 3)
            {
                // Log error message and return null
                return null; 
            }
            double lat;
            double lon;
            // TODO: Grab the latitude from your array at index 0
            // You're going to need to parse your string as a `double`
            // which is similar to parsing a string as an `int`
            lat = ParseLatitude(cells[0]);
            // TODO: Grab the longitude from your array at index 1
            // You're going to need to parse your string as a `double`
            // which is similar to parsing a string as an `int`
            lon = ParseLongitude(cells[1]);

            // TODO: Grab the name from your array at index 2
            string name = cells[2];
            // TODO: Create a TacoBell class
            // that conforms to ITrackable : done

            // TODO: Create an instance of the Point Struct
            // TODO: Set the values of the point correctly (Latitude and Longitude) 

            Point location = new Point() { Latitude = lat, Longitude = lon};

            // TODO: Create an instance of the TacoBell class

            TacoBell newLocation = new TacoBell() { Location = location, Name = name };
            // TODO: Set the values of the class correctly (Name and Location)

            // TODO: Then, return the instance of your TacoBell class,
            // since it conforms to ITrackable

            return newLocation;
        }

        public double ParseLongitude (string val)
        {
            double lon;
            try
            {

                bool success = double.TryParse(val, out lon);
            }
            catch
            {
                throw new System.Exception("Could not parse longitude");
            }
            return lon;
        }
        public double ParseLatitude(string val)
        {
            double lat;
            try
            {

                bool success = double.TryParse(val, out lat);
            }
            catch
            {
                throw new System.Exception("Could not parse longitude");
            }
            return lat;
        }
    }
}
