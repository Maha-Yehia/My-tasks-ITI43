using System.Runtime.CompilerServices;

namespace task_4_Day5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Duration d1 = new(1,10,15);
            //Console.WriteLine(d1.ToString());

            //Duration d2 = new(3600); 
            //Console.WriteLine(d2.ToString());

            //Duration d3 = new(3650);
            //Console.WriteLine(d3.ToString());

            //Duration d4 = new(7800);
            //Console.WriteLine(d4.ToString());

            //Duration d5 = new(666);
            //Console.WriteLine(d5.ToString());

            //Duration d6 = new(50);
            //Console.WriteLine(d6.ToString());

            //Duration d7 = d1+d2;
            //Console.WriteLine(d7.ToString());

            //Duration d8 = d2 + 7810;
            //Console.WriteLine(d8.ToString());
            //Duration d9 =  7810 +d2;
            //Console.WriteLine(d9.ToString());

            //Duration d10 = d9++;
            //Console.WriteLine(d10.ToString());

            //Duration d11 = ++d9;
            //Console.WriteLine(d11.ToString());

            //Duration d12 = --d11;
            //Console.WriteLine(d12.ToString());


            // ------------------------------------------
            //Duration d2 = new(1,00,5);
            //Duration d3 = new(2, 10, 5); 
            //d3 -= d2 ; 
            //Console.WriteLine(d3.ToString());

            //Duration d4 = new(1,20, 5);
            //Duration d5 = new(2, 10, 15);
            //Console.WriteLine(d5>d4);
            //Console.WriteLine(d5< d4);

            //Duration d6 = new(2,10, 15);
            //Duration d7 = new(2, 10, 15);
            //Console.WriteLine(d6 >= d7);
            //Console.WriteLine(d6 <= d7);


            //Duration d8 = new(0, 0, 0);

            //if (d8)
            //{
            //    Console.WriteLine("true");
            //}
            //else Console.WriteLine("false");

            Duration d9 = new(2, 10, 0); 
            //DateTime obj = (DateTime) d9; 
            //Console.WriteLine(obj);

            Duration d10 =- d9;
            Console.WriteLine(d10.ToString());

        }

        class Duration
        {
            int hour, minute, second;
            public override string ToString()
            {
                if (hour == 0 && minute != 0) {
                    return $"Minutes:{minute} Seconds:{second}";

                }

                else if (hour == 0 && minute == 0)
                    return $"Seconds:{second}";

                else return $"Hours:{hour} Minutes:{minute} Seconds:{second}";

            }

            public static bool operator ==(Duration a, Duration b)
            {
                return a.hour == b.hour && a.minute == b.minute && a.second == b.second;
            }

            public static bool operator !=(Duration a, Duration b)
            {
                return a.hour != b.hour || a.minute != b.minute || a.second != b.second ;
            }
            //---------constructors 
            public Duration(int hour, int minute, int second)
            {
                this.hour = hour;
                this.minute = minute;
                this.second = second;
            }

            public Duration(int sec)
            {
                this.hour = sec / 3600;
                this.minute = (sec - (3600 * hour)) / 60;
                this.second = sec - (3600 * hour) - (minute * 60);
            }

            public Duration()
            {
                this.hour = 0;
                this.minute = 0;
                this.second = 0;

            }

            ///----------operators overloading

            static public Duration operator +(Duration a, Duration b)
            {
                return new Duration()
                {
                    hour = a.hour + b.hour,
                    minute = a.minute + b.minute,
                    second = a.second + b.second
                };
            }

            static public Duration operator +(Duration a, int sec)
            {
                return new Duration()
                {
                    hour = a.hour + sec / 3600,
                    minute = a.minute + (sec - (3600 * (sec / 3600))) / 60,
                    second = a.second + (sec - (3600 * (sec / 3600)) - (((sec - (3600 * (sec / 3600))) / 60) * 60))
                };
            }

            static public Duration operator +(int sec, Duration a)
            {
                return new Duration()
                {
                    hour = a.hour + sec / 3600,
                    minute = a.minute + (sec - (3600 * (sec / 3600))) / 60,
                    second = a.second + (sec - (3600 * (sec / 3600)) - (((sec - (3600 * (sec / 3600))) / 60) * 60))
                };
            }

            static public Duration operator ++(Duration a)
            {
                int sec = a.hour * 3600 + a.minute * 60 + a.second + 60;
                return new Duration()
                {
                    hour = sec / 3600,
                    minute = (sec - (3600 * (sec / 3600))) / 60,
                    second = (sec - (3600 * (sec / 3600)) - (((sec - (3600 * (sec / 3600))) / 60) * 60))
                };

            }

            static public Duration operator --(Duration a)
            {
                int sec = a.hour * 3600 + a.minute * 60 + a.second - 60;
                return new Duration()
                {
                    hour = sec / 3600,
                    minute = (sec - (3600 * (sec / 3600))) / 60,
                    second = (sec - (3600 * (sec / 3600)) - (((sec - (3600 * (sec / 3600))) / 60) * 60))
                };

            }

            static public Duration operator - (Duration a, Duration b)
            {
                return new Duration()
                {
                    hour = a.hour - b.hour,
                    minute = a.minute - b.minute,
                    second = a.second - b.second
                };
            }

            static public bool operator >(Duration a, Duration b)
            {
                int seca = a.hour * 3600 + a.minute * 60 + a.second - 60;
                int secb = b.hour * 3600 + b.minute * 60 + b.second - 60;
                return seca > secb;
            }

            static public bool operator <(Duration a, Duration b)
            {
                int seca = a.hour * 3600 + a.minute * 60 + a.second - 60;
                int secb = b.hour * 3600 + b.minute * 60 + b.second - 60;
                return seca < secb;
            }
            static public bool operator <=(Duration a, Duration b)
            {
                int seca = a.hour * 3600 + a.minute * 60 + a.second - 60;
                int secb = b.hour * 3600 + b.minute * 60 + b.second - 60;
                return seca <= secb;
            }

            static public bool operator >=(Duration a, Duration b)
            {
                int seca = a.hour * 3600 + a.minute * 60 + a.second - 60;
                int secb = b.hour * 3600 + b.minute * 60 + b.second - 60;
                return seca >= secb;
            }
           

   
            static public bool operator true (Duration a)
            {
                return a.hour >= 0 || a.minute >= 0 || a.second >= 0;
                }

            static public bool operator false (Duration a)
            {
                return a.hour <= 0 && a.minute <= 0 && a.second <= 0;
            }



            static public explicit operator DateTime (Duration a)
            {
               DateTime date= new(); 
               return date.AddHours(a.hour).AddMinutes(a.minute).AddSeconds(a.second);
             
            }

            static public Duration operator - (Duration a)
            {
                return new Duration
                {
                    hour = -a.hour,
                    minute = -a.minute,
                    second = -a.second
                };
                   
              
               
            }




        }


    }
}