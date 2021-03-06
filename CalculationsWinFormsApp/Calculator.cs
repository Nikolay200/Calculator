using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Text;

namespace CalculationsWinFormsApp
{
    public partial class Calculator : Component
    {
        public System.Threading.Thread FactorialThread;
        public System.Threading.Thread FactorialMinusOneThread;
        public System.Threading.Thread AddTwoThread;
        public System.Threading.Thread LoopThread;

        public int varAddTwo;
        public int varFact1;
        public int varFact2;
        public int varLoopValue;
        public double varTotalCalculations = 0;

        public delegate void FactorialCompleteHandler(double Factorial, double TotalCalculations);
        public delegate void AddTwoCompleteHandler(int Result, double TotalCalculations);
        public delegate void LoopCompleteHandler(double TotalCalculations, int Counter);

        public event FactorialCompleteHandler FactorialComplete;
        public event FactorialCompleteHandler FactorialMinusOneComplete;
        public event AddTwoCompleteHandler AddTwoComplete;
        public event LoopCompleteHandler LoopComplete;

        public void FactorialMinusOne()
        {
            double varTotalAsOfNow = 0;
            double varResult = 1;
            
            for (int varX = 1; varX <= varFact2 - 1; varX++)
            {
                varResult *= varX;

                lock(this)
                {
                    varTotalCalculations += 1;
                    varTotalAsOfNow = varTotalCalculations;
                }
                
            }
            
            FactorialMinusOneComplete(varResult, varTotalAsOfNow);
        }

        
        public void Factorial()
        {
            double varResult = 1;
            double varTotalAsOfNow = 0;
            for (int varX = 1; varX <= varFact1; varX++)
            {
                varResult *= varX;
                lock (this)
                {
                    varTotalCalculations += 1;
                    varTotalAsOfNow = varTotalCalculations;
                }
                 
            }
            FactorialComplete(varResult, varTotalAsOfNow);
        }

        
        public void AddTwo()
        {
            double varTotalAsOfNow = 0;
            int varResult = varAddTwo + 2;
            lock (this)
            {
                varTotalCalculations += 1;
                varTotalAsOfNow = varTotalCalculations;
            }
              
            AddTwoComplete(varResult, varTotalAsOfNow);
        }

        
        public void RunALoop()
        {
            int varX;
            double varTotalAsOfNow = 0;
            for (varX = 1; varX <= varLoopValue; varX++)
            {
                
                for (int varY = 1; varY <= 500; varY++)
                {
                    lock (this)
                    {
                        varTotalCalculations += 1;
                        varTotalAsOfNow = varTotalCalculations;
                    }
                     
                }
            }
            LoopComplete(varTotalAsOfNow, varLoopValue);
        }

        public Calculator()
        {
            InitializeComponent();
        }

        public Calculator(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        public void ChooseThreads(int threadNumber)
        {
            
            switch (threadNumber)
            {
                case 1:
                    
                    FactorialThread = new System.Threading.Thread(new
                       System.Threading.ThreadStart(this.Factorial));
                   
                    FactorialThread.Start();
                    break;
                case 2:
                    FactorialMinusOneThread = new
                       System.Threading.Thread(new
                          System.Threading.ThreadStart(this.FactorialMinusOne));
                    FactorialMinusOneThread.Start();
                    break;
                case 3:
                    AddTwoThread = new System.Threading.Thread(new
                        System.Threading.ThreadStart(this.AddTwo));
                    AddTwoThread.Start();
                    break;
                case 4:
                    LoopThread = new System.Threading.Thread(new
                       System.Threading.ThreadStart(this.RunALoop));
                    LoopThread.Start();
                    break;
            }
        }
    }
}
