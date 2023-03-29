using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bussiness_logic_tear.Entity
{
    public class Titel:BaseEntity
    {
		string title;
        public string Title {
			get => title;
			set
			{
				if (title!=value)
				{
					if(EntityState!=State.Added)
					EntityState=State.Changed; 
					title = value;
				}
			}
		}
		string title_id;
        public string Title_id 
		{
            get => title_id;
            set
            {
                if (title_id != value)
                {
                    if (EntityState != State.Added)
                        EntityState = State.Changed;
                    title_id = value;
                }
            }
        }
        
        string type;
        public string?  Type {
			get => type; 
			set
			{
				if(type != value)
				{
					if(this.EntityState!=State.Added)
					this.EntityState = State.Changed;
                    type = value;
                }
			}
		}

		string? pub_id;
        public string? Pub_id
		{
            get => pub_id;
            set
            {
                if (pub_id != value)
                {
                    if (EntityState != State.Added)
                        EntityState = State.Changed;
                    pub_id = value;
                }
            }
        }

		decimal? price;
        public decimal? Price
		{
            get => price;
            set
            {
                if (price != value)
                {
                    if (EntityState != State.Added)
                        EntityState = State.Changed;
                    price = value;
                }
            }
        }

		decimal? advance;
        public decimal? Advance
		{
            get => advance;
            set
            {
                if (advance != value)
                {
                    if (EntityState != State.Added)
                        EntityState = State.Changed;
                    advance = value;
                }
            }
        }

		int? royalty;
        public int? Royalty 
		{
            get => royalty;
            set
            {
                if (royalty != value)
                {
                    if (EntityState != State.Added)
                        EntityState = State.Changed;
                    royalty = value;
                }
            }
        }

		int? ytd_sales;
        public int? Ytd_sales 
		{
            get => ytd_sales;
            set
            {
                if (ytd_sales != value)
                {
                    if (EntityState != State.Added)
                        EntityState = State.Changed;
                    ytd_sales = value;
                }
            }
        }

		string? notes;
        public string? Notes
		{
            get => notes;
            set
            {
                if (notes != value)
                {
                    if (EntityState != State.Added)
                        EntityState = State.Changed;
                    notes = value;
                }
            }
        }


		DateTime pubdate;
        public DateTime Pubdate {
            get => pubdate;
            set
            {
                if (pubdate != value)
                {
                    if (EntityState != State.Added)
                        EntityState = State.Changed;
                    pubdate = value;
                }
            }
        }
		


 
    }
}
