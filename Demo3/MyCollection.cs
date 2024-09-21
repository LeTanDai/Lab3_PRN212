using System;
using System.Collections;
using System.Collections.Generic;

public class MyCollection<T> : IEnumerable<T> where T : class, new()
{
    private List<T> list = new List<T>();

    public void AddItem(params T[] items) => list.AddRange(items);

    public IEnumerator<T> GetEnumerator() => list.GetEnumerator();

    IEnumerator IEnumerable.GetEnumerator() => list.GetEnumerator();
}
