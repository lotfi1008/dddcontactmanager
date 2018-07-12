using System;
using System.Collections.Generic;
using System.Text;

namespace ContactManager.Data.EF.Repositories
{
    public class BaseRepository
    {
        protected readonly ContactDBContext _ctx;

        public BaseRepository(ContactDBContext contactDBContext)
        {
            _ctx= contactDBContext;
        }
    }
}
