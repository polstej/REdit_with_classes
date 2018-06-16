using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REdit_with_classes
{
    class SettingsConfigurer
    {
        private string vocabularyDirectory;//where vocab files stored
        private string reportBodyHeader; //"RESULT"
        private string reportImpressionHeader;//"IMPRESSION"
        private string reportTechniqueHeader; //TECHNIQUE:"
        private int thresholdFrequency;// 5 or 10%
        private string applicationWindowName; // ="Powerscribe 360"
        private string reportComparisonHeader; //"comparison'

        //properties to get/set and check
        public string BodyHeader
        { get
            {
                return reportBodyHeader;
            }
            set
            {
                reportBodyHeader = value;
            }

        }

        public string TechniqueHeader
        {
            get
            {
                return reportTechniqueHeader;
            }
            set
            {
                reportTechniqueHeader = value;
            }

        }



        public SettingsConfigurer(string body, string technique)
        { }

        //contructor accepting all these parameters from the 

        //methods
        //send and recieve info from a file (can have separate
        //class for dealing w files)

    }
}
