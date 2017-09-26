using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConverterLibrary
{
    public class Converter
    {
        public const decimal LBS_TO_KGS = 1 / 2.20462M;
        public const decimal INCH_TO_CM = 2.54M;
        public const int INCH_TO_FT = 12;

        public enum Category
        {
            Length = 1,
            Weight,
            Temperature,
            Area,
            Volume
        }

        public enum MesurementSystem
        {
            Metric = 1,
            British,
            Scientific
        }

        public MesurementSystem From { get; set; }
        public MesurementSystem To { get; set; }

        public decimal GetBMI(decimal metric_height, decimal metric_weight)
        {
            decimal bmi = 0;
            try
            {
                bmi = metric_weight / (metric_height * metric_height);
            }
            catch (Exception ex)
            {
                // Exception handling logic goes here
                //ex.Message;
            }
            return bmi;
        }

        public decimal LengthToMetric(int feet, decimal inches)
        {
            decimal resulting_length = 0;
            try
            {
                decimal inches_in_feet = feet * INCH_TO_FT;
                resulting_length = (inches + inches_in_feet) * INCH_TO_CM;
            }
            catch (Exception ex)
            {
                // ex.Message;
            }
            return resulting_length;
        }

        public decimal WeightToMetric(decimal lbs)
        {
            decimal resulting_weight = lbs * LBS_TO_KGS;
            return resulting_weight;
        }

        public Converter()
        {

        }
    }
}
