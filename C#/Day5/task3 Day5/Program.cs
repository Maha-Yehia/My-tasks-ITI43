namespace task3_Day5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //------------------1---------------
            //Console.WriteLine(NIC.GetNIC()); 

            //------------------2---------------
            //Console.WriteLine(NIC.singleTonObj);
            //------------------3---------------
            Console.WriteLine(NIC.singleTonObj);

            //NIC n1 = new NIC(); ///// not valid as we not issue a pubic ctor
            //NIC.singleTonObj = "hkhdf" ///not valid we not issue set for obj 




        }

        class NIC
        {
            string? manufacture;
            string? MACAddress;
            string? type;

            static NIC obj;

            //------------------1--------------- static function & attribute
            //public static NIC GetNIC()
            //{
            //    if (obj == null)
            //    {
            //        return new NIC
            //        {
            //            manufacture = "ITI",
            //            MACAddress = "1215454",
            //            type = "SD"
            //        };
            //    };
            //    return obj;
            //}

            //------------------2--------------- static attribue
            //public static NIC singleTonObj { get; } = new("ITI", "1215454", "SD");
            private NIC (string manufacture , string MACAddress , string type)
            {
                this.manufacture = manufacture;
                this.MACAddress = MACAddress;
                this.type = type;
            }
            //------------------3--------------- static ctor and static attribute
            static NIC()
            {
                obj = new("ITI", "1215454", "SD"); 
            }

            public static NIC singleTonObj { get { return obj; } }


            public override string ToString()
            {
                return $"NIC: manufacture = {manufacture} ,MACAddress = {MACAddress} ,Type = {type}";
            }

        }

    }
}