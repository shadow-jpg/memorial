using Memorial.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Memorial.services;
namespace Memorial.Pages
{
    public class ReadChapterModel : PageModel
    {
        private readonly ChapterService _chapterService;

        public ReadChapterModel(ChapterService chapterService)
        {
            _chapterService = chapterService;
        }

        public Chapter CurrentChapter { get; set; }
        public List<Chapter> Chapters { get; set; }

        public void OnGet(int id)
        {
            Chapters = _chapterService.GetChapters();
            CurrentChapter = _chapterService.GetChapterById(id) ?? Chapters.First();
        }
    }
}
