using System.IO.MemoryMappedFiles;
using System.Web.Mvc;
using System.Web;
using Nwd.BackOffice.Impl;
using Nwd.BackOffice.Model;
using WebApplication.Models;

namespace WebApplication.Controllers
{
    public class AdminController:Controller
    {


        private AlbumRepository albumReprisotory=new AlbumRepository();

        [Authorize(Users ="SuperAdmin@oo.fr" )]
        [AllowAnonymous]
        public ActionResult Index()
        {

                return View();
        
        }

        
        public ActionResult Albums()
        {

            return View(new AlbumViewModels(albumReprisotory));

        }


    



        public ActionResult List()
        {

            return View(new AlbumViewModels(albumReprisotory));
           
        }




        public ActionResult Delete(int id)
        {
          var album= albumReprisotory.GetAlbumForEdit(id);
            albumReprisotory.DeleteAlbum(id);
            return RedirectToAction("List");

        }






        public ActionResult Create()
        {
           
                return View();
                
       
        }

        [HttpPost]
        public ActionResult Create(CreateViewModels retour)
        {

            var album = new Album();

            UpdateAlbum(retour, album);

            albumReprisotory.CreateAlbum(album,Server);

            return View(retour);


        }

        private static void UpdateAlbum(CreateViewModels retour, Album album)
        {
            album.Artist = retour.Artist;
            album.CoverImagePath = retour.CoverImagePath;
            album.Type = retour.Type;
            album.Duration = retour.Duration;
            album.ReleaseDate = retour.ReleaseDate;
            album.Title = retour.Title;
        }
    }
}