using bussiness_logic_tear.Entities_List;
using bussiness_logic_tear.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UI;

namespace bussiness_logic_tear.Entity_Manager
{
    public class titelsManager
    {
        public static Data_base_Manager DBmanager=new();
        
        public static titleList selectAllTitels()
        {
            try
            {
             return dataTableToTitel( DBmanager.excuteDatatTable("selectAllTitels"));
            }
            
            catch
            {
                return new titleList();
            }
        }

        public static titleList dataTableToTitel( DataTable dt)
        {
            titleList title = new titleList();
            foreach(DataRow dr in dt.Rows )
            {
                title.Add(rowToTitel(dr));
            }
            return title;
        }

        public static Titel rowToTitel(DataRow dr)
        {
            Titel obj = new Titel();

            if ( dr["title"] != null)
                obj.Title = dr["title"]?.ToString()??"NA";
            
                obj.Title_id = dr["title_id"]?.ToString() ?? "NA";
                        
                obj.Type = dr["type"]?.ToString() ?? "NA";

                obj.Pub_id = dr["pub_id"]?.ToString() ?? "NA";

            if (decimal.TryParse( dr["price"]?.ToString()??"-1" , out decimal output))
                obj.Price = output;

            if (decimal.TryParse(dr["advance"]?.ToString() ?? "-1", out  output))
                obj.Advance = output;

            if (int.TryParse(dr["royalty"]?.ToString() ?? "-1", out int outputInt))
                obj.Royalty = outputInt;

            if (int.TryParse(dr["ytd_sales"]?.ToString() ?? "-1", out outputInt))
                obj.Ytd_sales = outputInt;

            
                obj.Notes = dr["notes"]?.ToString() ?? "NA";

            if (DateTime.TryParse(dr["pubdate"]?.ToString() ?? "0/0/0", out DateTime date))
                obj.Pubdate = date;

            obj.EntityState = State.Unchanged;
            return obj;
        }

        
        
        public static bool updateTitelById
            (
            string TitleID, 
            string TitleName,
            string Type,
            string PubID,
            decimal? Price,
            decimal? Advance,
            int? Royalty,
            int? ytd_sales,
            string notes,
            DateTime pubdate
            )
        {
            try
            {
                Dictionary<string, object> dic = new() { 
                    ["@TitleID"] = TitleID,
                    ["@TitleName"] = TitleName,
                    ["@Type"] = Type,
                    ["@PubID"] = PubID,
                    ["@Price"] = Price,
                    ["@Advance"] = Advance,
                    ["@Royalty"] = Royalty,
                    ["@ytd_sales"] = ytd_sales,
                    ["@notes"] = notes,
                    ["@pubdate"] = pubdate,
                };
                return DBmanager.executeNonQuery("updateTitelNameById", dic) > 0;
            }
            catch
            {
                return false;
            }

            
        } 

    }
}
