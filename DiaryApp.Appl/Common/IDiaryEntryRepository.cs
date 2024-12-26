using Diary_App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DiaryApp.Appl.Common
{
    public interface IDiaryEntryRepository
    {
        IEnumerable<DiaryEntry> GetAll(Expression<Func<DiaryEntry,bool>>? filter=null);
        IEnumerable<DiaryEntry> Get(Expression<Func<DiaryEntry, bool>> filter);

        void Add(DiaryEntry entry);
        void Remove(DiaryEntry entry);
        void Update(DiaryEntry entry);
        void Save(DiaryEntry entry);
    }
}
