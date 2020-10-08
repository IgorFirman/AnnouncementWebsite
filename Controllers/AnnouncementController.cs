using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using AnnouncementWebsite.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AnnouncementWebsite.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnnouncementController : ControllerBase
    {
        private readonly ApplicationContext applicationContext;
        public AnnouncementController(ApplicationContext applicationContext)
        {
            this.applicationContext = applicationContext;
            if (!applicationContext.Announcements.Any())
            {
                
                this.applicationContext.Announcements.Add(new Announcement
                {
                    Title = "100% оригинальні куртки Alpha Industries, США",
                    Description = "В наявності чоловічі, жіночі та дитячі весняні бомберы, зимові куртки аляски, літні вітровки, реглани," +
                " футболки - вся продукція оригинальна та дуже якісна. Також відправляємо Новою Поштою в будь - яке місто України.",
                    DateAdded = new DateTime(2020, 7, 15, 18, 42, 0)
                });
                this.applicationContext.Announcements.Add(new Announcement
                {
                    Title = "Американські осінні куртки Top Gun (Топ Ган), США",
                    Description = "Гарно сидить по фігурі, приталена. Куртка має міцний металевий замок. Комір виготовлений зі штучного хутра," +
                    " яке можна відстебнути. Модель B-15 Flight Bomber Jacket розрахована на осінь/весну.- верх куртки - 100 % льотний нейлон." +
                    "Підкладка - поліестер.Розміри в наявності від XS до 5XL",
                    DateAdded = new DateTime(2020, 8, 10, 21, 2, 0)
                });
                this.applicationContext.Announcements.Add(new Announcement
                {
                    Title = "Медичні маски багаторазові 15 грн",
                    Description = "Склад: 100% бавовна, ч" +
                    "отирьохшарові (2 середніх шари з марлі)Є варіанти на резинці і на зав‘язках. Розміри: 16 см на 20 см(в розкладеному вигляді). " +
                    "Ціна упаковки 15 шт - 200 грн",
                    DateAdded = new DateTime(2020, 7, 16, 10, 22, 0)
                });
                this.applicationContext.Announcements.Add(new Announcement
                {
                    Title = "Ремонт ноутбуків та комп'ютерів",
                    Description = "Встановлення, відновлення та " +
                    "налаштування операційних систем, програм, антивірусів, драйверів.Налаштування підключення до мережі Internet, Wi - Fi обладнання, прошивка роутерів. " +
                    "Підбір конфігурації комп'ютера, заміна та тестування компьютерних комплектуючих. Відновлення інформації з HDD та переносних пристроїв. Продаж нових та " +
                    "бу комплектуючих.Діагностика та усунення проблем з налаштуванням операційної системи за допомогою віддаленого доступу.",
                    DateAdded = new DateTime(2020, 7, 19, 9, 0, 0)
                });
                this.applicationContext.Announcements.Add(new Announcement
                {
                    Title = "Електрик Львів. Виклик електрика у Львові. Відновлення світла.",
                    Description = "Наші електрики стануть незамінними " +
                    "помічниками для вас у наступних питаннях: відновлення зниклого світла усунення наслідків короткого замикання; ремонт розеток та вимикачів; ремонт люстр, світильників, бра; заміна електропроводу; " +
                    "виявлення пошкоджень та обриву лінії; заміна автоматів та пробок; заміна лічильників; ревізія щитка та його заміна; проведення розетки для бойлера, пральної машини; виконуємо штробління " +
                    "та інші демонтажні роботи; ",
                    DateAdded = new DateTime(2020, 8, 1, 11, 46, 0)
                });
                this.applicationContext.Announcements.Add(new Announcement
                {
                    Title = "Курси моделювання, крою та пошиття одягу",
                    Description = "Школа VK постійно набирає на курси крою і шиття, моделювання одягу." +
                    " Навчання на сучасних машинках і оверлоках.Заняття ранкові кожен день з 10.00 до 13.00(суботу з 11.00 до 14.00) і вечірні з 18.00 до 21.00 по понеділках середах і п'ятницях. Вартість курсів 1200 " +
                    "грн.за місяць навчання(12 занять).За пропущені заняття Ви не платите. Диплом по закінченню курсів.",
                    DateAdded = new DateTime(2020, 8, 2, 19, 52, 0)
                });
                this.applicationContext.Announcements.Add(new Announcement
                {
                    Title = "Ремонт квартир, котеджів, офісів",
                    Description = "Будівельна бригада Костянтин виконує всі види робіт - від косметичного ремонту " +
                    "до реалізації оригінальних дизайн -проектів у Львові та Львівській області. Ми чітко виконуємо поставлене перед нами завдання. Організовуємо своєчасну поставку матеріалів на об'єкт, зробимо закупівлю," +
                    " організовуємо вивіз будівельного сміття. т. 0986272440 Костя",
                    DateAdded = new DateTime(2020, 8, 5, 12, 2, 0)
                });
                this.applicationContext.Announcements.Add(new Announcement
                {
                    Title = "АКЦІЯ !!! 55 тис! Вагончик Битовка МАФ Пост охорони",
                    Description = "Ціна даного вагона на металевому каркасі 6х2.5 вартує 55 тис грн. Повністю утеплений. Оброблений антикором, паро/гідробарєр." +
                    " Компанія Bud_Karkas виготовляє під замовленння модульні вагончики, пости охорони, мобільні офіси, кіоски , дачні будиночки, торгові павільони, битовки. Також є завжди в наявності готові моделі.Ціна найнижча в " +
                    "регіоні. Зробимо швидко і якісно!!! Перевозиться швидко та легко.",
                    DateAdded = new DateTime(2020, 8, 11, 14, 24, 0)
                });
                this.applicationContext.SaveChanges();
            }
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Announcement>>> Get()
        {
            return await applicationContext.Announcements.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Announcement>> Get(int id)
        {
            var announc = await this.applicationContext.Announcements.FirstOrDefaultAsync(a => a.AnnouncementId == id);
            if (announc == null)
            {
                return NotFound();
            }
            return new ObjectResult(announc);
        }
        [HttpGet("{similar}/{id}")]
        public async Task<ActionResult<IEnumerable<Announcement>>> GetSimilarAnnouncement(int id)
        {
            var selectedAnnouncement = await this.applicationContext.Announcements.FirstOrDefaultAsync(a => a.AnnouncementId == id);
            List<Announcement> announcement = await this.applicationContext.Announcements.ToListAsync();
            List<Announcement> similaryAnnouncementToSelectedAnnouncement = new List<Announcement>(3);
            foreach (var an in announcement)
            {
                if(!selectedAnnouncement.Equals(an) && (selectedAnnouncement.Title.Split()
                         .Intersect(an.Title.Split())
                         .Any() || selectedAnnouncement.Description.Split()
                         .Intersect(an.Description.Split())
                         .Any()))
                {
                    if (similaryAnnouncementToSelectedAnnouncement.Count < 3)
                    {
                        similaryAnnouncementToSelectedAnnouncement.Add(an);
                    }
                    else
                    {
                        break;
                    }
                    
                }
            }
            return similaryAnnouncementToSelectedAnnouncement;
        }

        [HttpPost]
        public async Task<ActionResult<Announcement>> Post(Announcement announcement)
        {
            if(announcement == null)
            {
                return BadRequest();
            }
            this.applicationContext.Announcements.Add(announcement);
            await this.applicationContext.SaveChangesAsync();
            return Ok(announcement);
        }

        [HttpPut]
        public async Task<ActionResult<Announcement>> Put(Announcement announcement)
        {
            if (announcement == null)
            {
                return BadRequest();
            }
            if (!this.applicationContext.Announcements.Any(announc => announc.AnnouncementId == announcement.AnnouncementId))
            {
                return NotFound();
            }

            this.applicationContext.Update(announcement);
            await this.applicationContext.SaveChangesAsync();
            return Ok(announcement);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Announcement>> Delete(int id)
        {
            var announcement = await this.applicationContext.Announcements.FirstOrDefaultAsync(a => a.AnnouncementId == id);
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            this.applicationContext.Announcements.Remove(announcement);
            await this.applicationContext.SaveChangesAsync();
            return Ok(announcement);
        }


    }
}
