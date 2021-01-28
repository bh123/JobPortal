using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.Caching;
using System.Web.Http;
using System.Web.Http.Description;
using JobPortal.Models;

namespace JobPortal.Controllers
{


    public static class MemoryCacher
    {
        public static object GetValue(string key)
        {
            MemoryCache memoryCache = MemoryCache.Default;
            return memoryCache.Get(key);
        }

        public static bool Add(string key, object value, DateTimeOffset absExpiration)
        {
            MemoryCache memoryCache = MemoryCache.Default;
            return memoryCache.Add(key, value, absExpiration);
        }

        public static void Delete(string key)
        {
            MemoryCache memoryCache = MemoryCache.Default;
            if (memoryCache.Contains(key))
            {
                memoryCache.Remove(key);
            }
        }
    }
    public class JobsController : ApiController
    {

        //GET: api/Jobs
        public List<getJobs_Result> GetJobs(int CityId, int SkillId, int ExpYear)
        {

            var list = (List<getJobs_Result>)MemoryCacher.GetValue("CacheItem1");



            if (list != null && list.Count > 0)
            {
                return list;
            }
            else
            {
                using (JobsDBEntities db = new JobsDBEntities())
                {
                    var result = db.getJobs(CityId, SkillId, ExpYear).ToList();
                    MemoryCacher.Add("CacheItem1", result, DateTimeOffset.UtcNow.AddYears(1));

                    return result;
                }
            }

        }

    }
}

