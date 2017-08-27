using UnityEngine;
using System.Collections;
using NUnit.Framework;
using Lean;

public class TestLeanClassPool
{
    [Test]
    public void CanNotSpawnWhenEmpty ()
    {
        LeanClassPool <Object>.Clear ();
        Assert.IsNull (LeanClassPool <Object>.Spawn ());
    }

    [Test]
    public void CanSpawnLastObject ()
    {
        LeanClassPool <Object>.Clear ();
        var o = new Object ();
        LeanClassPool <Object>.Despawn (o);

        Assert.AreSame (LeanClassPool <Object>.Spawn (), o);
    }

    [Test]
    public void CanSpawnObjectByType ()
    {
        LeanClassPool.Clear ();
        var o = new TestLeanClassPool ();
        LeanClassPool.Despawn (o);

        Assert.AreSame (LeanClassPool.Spawn <TestLeanClassPool>(), o);
    }
}
