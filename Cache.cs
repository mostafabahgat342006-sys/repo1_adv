namespace c__Advanced_ass1;

public class Cache<TKey, TValue> where TKey : notnull
{

    private Dictionary<TKey, (TValue Value , DateTime Expiry)> items
    = new Dictionary<TKey, (TValue, DateTime)>();




    //  يجيب الوقت الحالي مثلا  : 10:00 DateTime.Now
    //  يضيف عليه 60 ثانية مثلا  :  10:01. AddSeconds(seconds)
    //    يخزن ان 10:01 وقت انتهاء الصلاحية.
    public void Add(TKey key, TValue value, int seconds)
    {
        items[key] = (value, DateTime.Now.AddSeconds(seconds));
    }


   // تتأكد إن المفتاح موجود.
  // تتأكد إن مدة صلاحيته لسه منتهتش.
    public bool Contains(TKey key)
    {
        if (items.ContainsKey(key))
        {
            if (DateTime.Now < items[key].Expiry)
                return true;

            items.Remove(key);
        }

        return false;
    }




    public TValue Get(TKey key)
    {
        if (Contains(key))
            return items[key].Value;

        return default(TValue);
    }



    public void Remove(TKey key)
    {
        items.Remove(key);
    }


}
