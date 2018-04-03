using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConvertToUTM {

    // earth radius reference : https://nssdc.gsfc.nasa.gov/planetary/factsheet/earthfact.html
    double r = 6378.137;
    float lon;
    float lat;

    public ConvertToUTM(float longitude, float latitude)
    {
        lon = longitude;
        lat = latitude;
    }

    public double[] ConvertCoordinate()
    {
        // Longlat to UTM Conversion Formula
        // Simplified Formula from JOHN P. SNYDER https://pubs.usgs.gov/pp/1395/report.pdf
        double x = r * System.Math.Sin(lat) * System.Math.Cos(lon);
        double y = r * System.Math.Sin(lat) * System.Math.Sin(lon);
        double[] xy = { x, y };
        return xy;
    }
}
