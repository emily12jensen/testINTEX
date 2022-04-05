﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace testINTEX.Models
{
    public class crash
    {
        [Key]
        [Required]
        public int crash_id { get; set; }
        public double route { get; set; }
        public double milepoint { get; set; }
        public double lat_utm_y { get; set; }
        public double long_utm_x { get; set; }
        public string main_road_name { get; set; }
        public string city { get; set; }
        public string county_name { get; set; }
        public double crash_severity_id { get; set; }
        public string work_zone_related { get; set; }
        public string pedestrian_involved { get; set; }
        public string bicyclist_involved { get; set; }
        public string motorcycle_involved { get; set; }
        public string improper_restraint { get; set; }
        public string unrestrained { get; set; }
        public string dui { get; set; }
        public string intersection_related { get; set; }
        public string wild_animal_related { get; set; }
        public string domestic_animal_related { get; set; }
        public string overturn_rollover { get; set; }
        public string commercial_motor_veh_involved { get; set; }
        public string teenage_driver_involved { get; set; }
        public string older_driver_involved { get; set; }
        public string night_dark_condition { get; set; }
        public string single_vehicle { get; set; }
        public string distracted_driving { get; set; }
        public string drowsy_driving { get; set; }
        public string roadway_departure { get; set; }
        public string outside_city_limits { get; set; }
        public string crash_date { get; set; }
        public string crash_time { get; set; }



    }
}