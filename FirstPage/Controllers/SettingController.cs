using AutoMapper;
using FirstPage.Interface;
using FirstPage.Models;
using FirstPage.Models.ViewModel;
using FirstPage.Reposaitry;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace FirstPage.Controllers
{
    public class SettingController : Controller
    {
        

        public SettingController(IUniteOfWork uniteOfWork,  IMapper mapper ,MohamedContext context)
        {


            UniteOfWork = uniteOfWork;
            Mapper = mapper;
            Context = context;
        }





        public IUniteOfWork UniteOfWork { get; }
        public IMapper Mapper { get; }
        public MohamedContext Context { get; }
        [HttpGet("ENTRY_SETTING_ID,LANG")]
        public async Task<IActionResult> Index()
        {

            var MappedResult = Mapper.Map<IEnumerable<GET_ENTRY_SETTINGResult>, IEnumerable<Get_Entry_SettingViewModel>>(UniteOfWork.entrySettingRepo.GetResultWithEntrySetting());

            return View(MappedResult);
        }
            [HttpGet("ENTRY_SETTING_ID,LANG")]
        public async Task<IActionResult> Index(short? ENTRY_SETTING_ID, string LANG)
        {
          
            var EntrySettingResult = await Context.GET_ENTRY_SETTINGResultasync.FromSqlRaw($"EXEC GET_ENTRY_SETTING {ENTRY_SETTING_ID=1 },{LANG="A"}").ToListAsync();

            return View(EntrySettingResult);


        }
    
    }
}
/*
 [HttpGet("ENTRY_SETTING_ID,LANG")]
 public async Task<IActionResult> Index(short? ENTRY_SETTING_ID, string LANG)
 {

     var MappedResult = Mapper.Map<IEnumerable<GET_ENTRY_SETTINGResult>, IEnumerable<Get_Entry_SettingViewModel>>

         (UniteOfWork.entrySettingRepo.GetResultWithEntrySetting(1,"A"));

     return Ok(MappedResult);
 }*/

/*[HttpGet("ENTRY_SETTING_ID,LANG")]
public async Task<ActionResult<IEnumerable<GET_ENTRY_SETTINGResult>>> Index(short? ENTRY_SETTING_ID, string LANG)
{
    var EntrySettingResult = await Context.GET_ENTRY_SETTINGResultasync.FromSqlRaw($"EXEC GET_ENTRY_SETTING {ENTRY_SETTING_ID=1 },{LANG="A"}").ToListAsync();
    return View(EntrySettingResult);


}*/





/*
     return View();
 }
 [Httppost()]
 public async Task<IActionResult> Index(short? ENTRY_SETTING_ID, string LANG)
 {
<html>
<head>

<link rel="stylesheet" href="~/css/about_index.css">
<link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css">

</head>
<body>
     var EntrySetting = await context.gET_ENTRY_SETTINGResults.FromSqlRaw($@"GET_ENTRY_SETTING {1},{"A"}").ToListAsync();
     return View(EntrySetting);
 }
}
/*

[HttpGet("{ENTRY_SETTING_ID ,LANG }")]
public async Task<ActionResult<List<GET_ENTRY_SETTINGResult>>>Index(short? ENTRY_SETTING_ID, string LANG)
{
 var EntrySettingResult = await UniteOfWork.entrySettingRepo.(MohamedContextProcedures.GET_ENTRY_SETTINGAsync(1,"A"));
 return View(EntrySettingResult);

}
*/
/*
 * SqlQueryAsync<GET_ENTRY_SETTINGResult>("EXEC @returnValue = [dbo].[GET_ENTRY_SETTING] @ENTRY_SETTING_ID, @LANG"
public async Task<ActionResult<List<GET_ENTRY_SETTINGResult>>>Index(int ENTRY_SETTING_ID, char LANG)
  {
    var EntrySettingResult = await Context.GetProcedures.FromSqlRaw($" GET_ENTRY_SETTING {ENTRY_SETTING_ID},{LANG = 'A'}").ToListAsync();
 return Ok(EntrySettingResult);

 }
*/
/*
public async Task<ActionResult<List<EntrySetting>>> Indexsp(int ENTRY_SETTING_ID, int SHIFT_NUMBER)
{
    var EntrySettingResult = await Context.entrySettings.FromSqlRaw($"EXEC Get_New_Entry_Number {ENTRY_SETTING_ID},{SHIFT_NUMBER}").ToListAsync();
    return View(EntrySettingResult);

}

*/
/*  
  public async Task<IActionResult> Index(short? ENTRY_SETTING_ID, string LANG)
  {

      var MappedResult = Mapper.Map<List<GET_ENTRY_SETTINGResult>>
          (UniteOfWork.entrySettingRepo.GetEntrySetting());

      return View(MappedResult);
  }
 */


/*
public IActionResult Index()
{
    var Currency = _context.Currencies.FromSqlRaw("SELECT_ALL_CURRENCIES").ToList();

    return View(Currency);
} 

[HttpGet]
public async Task<ActionResult<List<EntrySetting>>> Index()
{
    var EntrySetting = await _context.EntrySettings.ToListAsync();
    return Ok(EntrySetting);

}
*/







