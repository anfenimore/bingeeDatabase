using watchlist.models;

namespace watchlist.interfaces
{
    public interface ISaveShow
    {
        public void CreateShow(Show myShow);
        public void SaveShow(Show myShow);
    }
}