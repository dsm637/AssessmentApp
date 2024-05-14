namespace AssessmentApp.API
{
    public struct GeoCoordinate
    {
        public double Latitude { get; }
        public double Longitude { get; }

        public GeoCoordinate(double latitude, double longitude)
        {
            Latitude = latitude;
            Longitude = longitude;
        }

        public double DistanceTo(GeoCoordinate other)
        {
            var r = 3959; // Earth radius in miles
            var dLat = ToRadians(other.Latitude - this.Latitude);
            var dLon = ToRadians(other.Longitude - this.Longitude);
            var lat1 = ToRadians(this.Latitude);
            var lat2 = ToRadians(other.Latitude);

            var a = Math.Sin(dLat / 2) * Math.Sin(dLat / 2) +
                    Math.Sin(dLon / 2) * Math.Sin(dLon / 2) * Math.Cos(lat1) * Math.Cos(lat2);
            var c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));
            return r * c;
        }

        private static double ToRadians(double angle)
        {
            return Math.PI * angle / 180.0;
        }
    }
}
