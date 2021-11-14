using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Caching;

namespace school_record.Models
{
    public class StudentRepository : stumodel
    {

       

        dbcontext db = new dbcontext();
        public DbSet<stumodel> sb;

      
        
        
       
        //public StudentRepository()
        //    {
        //    stu = cache["stu"] as List<stumodel>;
        //    if(stu == null)
        //    {
        //        stu = new List<stumodel>();
        //    }

        //        }
        
       
        public void Commit()
        {
            db.SaveChanges();
           
        }

        public void Insert(stumodel s)
        {
            db.stu.Add(s);
           
        }
        public IQueryable<stumodel> Collection()
        {
            return db.stu.AsQueryable();
        }
        public void remove(stumodel st)
        {
           
            var t = Find(st.Id);
            db.stu.Remove(t);
        }

        public void update(stumodel st)
        {
            stumodel stuupdate = sb.Find(Id);
            if(stuupdate!=null)
            {

                stuupdate = st;
            }
            else { throw new Exception("no product find"); }
        }
        public stumodel Find(string id)
        {
            stumodel su = db.stu.Find(id);
            
            return su;
            

        }
        //public void Delete(string id)
        //{
            

        //}
    }
}