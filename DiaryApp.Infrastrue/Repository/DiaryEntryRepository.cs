using Diary_App.Models;
using DiaryApp.Appl.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DiaryApp.Infrastrue.Repository
{
    public class DiaryEntryRepository : IDiaryEntryRepository
    {
        public void Add(DiaryEntry entry)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<DiaryEntry> Get(Expression<Func<DiaryEntry, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<DiaryEntry> GetAll(Expression<Func<DiaryEntry, bool>>? filter = null)
        {
            throw new NotImplementedException();
        }

        public void Remove(DiaryEntry entry)
        {
            throw new NotImplementedException();
        }

        public void Save(DiaryEntry entry)
        {
            throw new NotImplementedException();
        }

        public void Update(DiaryEntry entry)
        {
            throw new NotImplementedException();
        }
    }
}
