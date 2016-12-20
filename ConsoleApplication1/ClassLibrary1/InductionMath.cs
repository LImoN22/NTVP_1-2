﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
  
  public  class InductResCalc : MathCount
    {
     private double _inductanceValue; 
     private double _frequencyValue;
   
             
      
            public InductResCalc( double InductionIn, double FrequencyIn )
            {
            _inductanceValue=InductionIn;
            _frequencyValue=FrequencyIn;
            }

            
     

        //методы        
        public double Calculation
        {
            get
            {

                return (2 * System.Math.PI * _frequencyValue * _inductanceValue);
            }
        }
        

        }

}
