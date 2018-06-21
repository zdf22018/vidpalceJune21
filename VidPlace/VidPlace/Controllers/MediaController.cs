using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VidPlace.Models;

namespace VidPlace.Controllers
{
    public class MediaController : Controller
    {
        // GET: Media
        /*public ActionResult Index()
        {
            return View();
        }*/

        [Route("media/index/{PageIndex:range(1,100)}/{sortby?}")]
        //public ActionResult Index(int? PageIndex, string sortby)
        //{
        //    if (!PageIndex.HasValue)
        //        PageIndex = 1;
        //    if (string.IsNullOrWhiteSpace(sortby))
        //        sortby = "name";

        //    return Content("Page # " + PageIndex + " | Sort by: " + sortby);
        //}

        [Route("media/released/{year:range(2000,2020)}/{month:range(1,12)}")]
        public ActionResult released(int year, int month)
        {
            return Content("Year = " + year + ", Month = " + month);
        }

        public ActionResult random()
        {
            var media = new Media();

            media.Name = "Ocean 8";
            media.ID = 2002;

            return View(media);
        }

        public ActionResult edit(int mediaID)
        {
            return Content("Provided ID = " + mediaID);
        }

        public ActionResult Index()
        {
            var medias = GetMedias();

            return View(medias);

        }

        

            private IEnumerable<Media> GetMedias()
            {
                List<Media> medias = new List<Media>();
                Media m1 = new Media();
            Media m2 = new Media();
            Media m3 = new Media();

            m1 = new Media { Name = "007 Casino", ID = 2, };
            m2 = new Media { Name = "007 Red Moulin", ID = 3, };
            m3 = new Media { Name = "007 blue globe", ID = 4, };
           
            medias.Add(m1);
            medias.Add(m2);
            medias.Add(m3);

            return medias;

            }
        }
        
    }
