using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using UnityEngine;

public class Render : MonoBehaviour {

    //data
    string bandung = @"Assets\Data\map-bandung_planet_osm_line_lines.kml";

    //classes
    XmlSerializer serializer;
    FileStream stream;
    kml container;
    ConvertToUTM converter;

    //index
    int placemark_index;
    

    [SerializeField]
    public GameObject titik;

    // Use this for initialization
    void Start () {
        //start at zero
        placemark_index = 0;

        //load kml data
        serializer = new XmlSerializer(typeof(kml));
        stream = new FileStream(bandung, FileMode.Open);
        container = (kml)serializer.Deserialize(stream);
        stream.Close();
    }
	
	// Update is called once per frame
	void Update () {

        //draw titik
        drawTitik();

        //index increment
        placemark_index = placemark_index + 1;
    }

    private void drawTitik()
    {
        //check index
        if (placemark_index < container.Document.Folder.Placemark.Length)
        {
            float longitude = (float)container.Document.Folder.Placemark[placemark_index].LookAt.longitude;
            float latitude = (float)container.Document.Folder.Placemark[placemark_index].LookAt.latitude;
            float altitude = (float)container.Document.Folder.Placemark[placemark_index].LookAt.altitude;
            string name = container.Document.Folder.Placemark[placemark_index].name;

            //convert to UTM
            converter = new ConvertToUTM(longitude, latitude);
            double[] xy = converter.ConvertCoordinate();

            //get position
            var position = new Vector3((float)xy[0], altitude, (float)xy[1]);

            //debugging
            Debug.Log("Lon:" + xy[0] + " Latitude:" + xy[1] + " Altitude:" + altitude);

            //initialize titik
            titik = Instantiate(titik);
            titik.name = "titik_" + name;

            //set titik position
            titik.transform.position = position;
        }
    }
}
