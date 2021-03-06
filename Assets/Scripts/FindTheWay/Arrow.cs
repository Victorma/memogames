﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour {

	void OnMouseDown()
    {
        CarMove car = GameObject.FindGameObjectWithTag("Car").GetComponent<CarMove>();
        //No se permite pulsar una flecha si está el mapa completo activado
        if (!car.mapOpened)
        {
            string tagPosition = null;

            Intersection inter = transform.parent.gameObject.GetComponent<Intersection>();
            inter.HideArrows();


            car.ResumeCar();
            //El coche ya no está en una interseción.
            car.intersection = false;
            

            switch (car.dir)
            {
                case CarMove.Direction.NE:

                    switch (name)
                    {
                        case "NW":
                            tagPosition = "L";
                            break;
                        case "NE":
                            tagPosition = "S";
                            break;
                        case "SE":
                            tagPosition = "R";
                            break;
                    }

                    break;
                case CarMove.Direction.SE:

                    switch (name)
                    {
                        case "SW":
                            tagPosition = "R";
                            break;
                        case "SE":
                            tagPosition = "S";
                            break;
                        case "NE":
                            tagPosition = "L";
                            break;
                    }

                    break;

                case CarMove.Direction.SW:

                    switch (name)
                    {
                        case "SE":
                            tagPosition = "L";
                            break;
                        case "SW":
                            tagPosition = "S";
                            break;
                        case "NW":
                            tagPosition = "R";
                            break;
                    }

                    break;

                default:

                    switch (name)
                    {
                        case "SW":
                            tagPosition = "L";
                            break;
                        case "NW":
                            tagPosition = "S";
                            break;
                        case "NE":
                            tagPosition = "R";
                            break;
                    }

                    break;
            }

            inter.ChangeTag(tagPosition, car.dir);
        }
    }
}