using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Michael.AoC
{
    internal class Day15
    {
        public static void Start()
        {
            int max = 200000000;
            int testRow = 2000000;

            List<((int, int), int)> sensors = new List<((int, int), int)>();

            string input = GetInput();

            string[] lines = input.Split("\r\n");

            foreach (string line in lines)
            {
                string[] words = line.Split(" ");

                string sensorX = words[2];
                string sensorY = words[3];
                string beaconX = words[8];
                string beaconY = words[9];

                sensorX = sensorX.Replace("x=", "").Replace(",", "");
                sensorY = sensorY.Replace("y=", "").Replace(":", "");
                beaconX = beaconX.Replace("x=", "").Replace(",", "");
                beaconY = beaconY.Replace("y=", "");

                int sX = int.Parse(sensorX);
                int sY = int.Parse(sensorY);
                int bX = int.Parse(beaconX);
                int bY = int.Parse(beaconY);

                ((int, int), int) sensor = ((sX, sY), DistanceBetween((sX, sY), (bX, bY)));

                sensors.Add(sensor);
            }

            int count = 0;
            int perc = 0;
            for (int i = -max; i <= max; i++)
            {
                (int, int) testCoordinate = (testRow, i);
                if (perc == 1000000)
                {
                    perc = 0;
                    Console.SetCursorPosition(0, 0);
                    Console.WriteLine($"{(double)(i + max) / (2 * max) * 100:N2}%");
                }

                foreach (var sensor in sensors)
                {
                    if (DistanceBetween(sensor.Item1, testCoordinate) <= sensor.Item2)
                    {
                        count++;
                        break;
                    }
                }
                perc++;
            }

            Console.WriteLine(count);
        }


        public static int DistanceBetween((int, int) coord1, (int, int) coord2)
        {
            return Math.Abs(coord1.Item1 - coord2.Item1) + Math.Abs(coord1.Item2 - coord2.Item2);
        }


        public static string GetInput()
        {
            return "Sensor at x=655450, y=2013424: closest beacon is at x=967194, y=2000000\r\nSensor at x=1999258, y=1017714: closest beacon is at x=3332075, y=572515\r\nSensor at x=2159800, y=3490958: closest beacon is at x=2145977, y=3551728\r\nSensor at x=3990472, y=1891598: closest beacon is at x=3022851, y=2629972\r\nSensor at x=188608, y=354698: closest beacon is at x=-1037755, y=-391680\r\nSensor at x=286630, y=3999086: closest beacon is at x=-1202308, y=3569538\r\nSensor at x=2022540, y=3401295: closest beacon is at x=2013531, y=3335868\r\nSensor at x=65063, y=2648597: closest beacon is at x=967194, y=2000000\r\nSensor at x=2533266, y=439414: closest beacon is at x=3332075, y=572515\r\nSensor at x=1728594, y=2416005: closest beacon is at x=967194, y=2000000\r\nSensor at x=1156357, y=1867331: closest beacon is at x=967194, y=2000000\r\nSensor at x=825519, y=3323952: closest beacon is at x=2013531, y=3335868\r\nSensor at x=3278267, y=201451: closest beacon is at x=3332075, y=572515\r\nSensor at x=3679732, y=1213595: closest beacon is at x=3332075, y=572515\r\nSensor at x=896808, y=1637672: closest beacon is at x=967194, y=2000000\r\nSensor at x=2035362, y=3363480: closest beacon is at x=2013531, y=3335868\r\nSensor at x=2056169, y=3442413: closest beacon is at x=2013531, y=3335868\r\nSensor at x=2631999, y=1884495: closest beacon is at x=3022851, y=2629972\r\nSensor at x=3149604, y=3870003: closest beacon is at x=3707835, y=4152776\r\nSensor at x=3579002, y=1702: closest beacon is at x=3332075, y=572515\r\nSensor at x=2306088, y=2605428: closest beacon is at x=3022851, y=2629972\r\nSensor at x=2428132, y=3171598: closest beacon is at x=2013531, y=3335868\r\nSensor at x=1447212, y=3938104: closest beacon is at x=2145977, y=3551728\r\nSensor at x=3131240, y=3166665: closest beacon is at x=3022851, y=2629972\r\nSensor at x=3865496, y=2980765: closest beacon is at x=3022851, y=2629972\r\nSensor at x=2508598, y=3611761: closest beacon is at x=2145977, y=3551728\r\nSensor at x=2144092, y=3514660: closest beacon is at x=2145977, y=3551728\r\nSensor at x=3947251, y=469499: closest beacon is at x=3332075, y=572515";
        }
    }


}
