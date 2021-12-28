using System;
using System.Collections.Generic;
using System.Text;

using Tremendous1192.SelfEmployed.CoMPASS.MathApp;

namespace Test.Tremendous1192.SelfEmployed.CoMPASS.MathApp
{
    public partial class InterfaceTest
    {
        /// <summary>
        /// interfaceの勉強用の関数
        /// </summary>
        public void Study01()
        {
            var gs = new GeometricShapes<string>();
            gs.Add("test 01");
            Console.WriteLine(gs.Get(0));
        }

    }


    /// <summary>
    /// 引用 - C# Programming: Creating and Using a Generic Interface。
    /// http://www.functionx.com/csharp40/interfaces/cugi.htm
    /// 。interfaceとgenericの勉強のために、引用した。
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IShapes<T>
    {
        //インターフェイスでジェネリック型を用いる場合、通常のクラスの場合と同様に<T>をインターフェイス名の末尾に記入すれば良い。

        int Count { get; }
        void Add(T item);
        //ジェネリック型のクラス定義も、通常のクラスの場合と同様のようである。
        T Get(int index);
    }

    /// <summary>
    /// 引用 - C# Programming: Creating and Using a Generic Interface
    /// http://www.functionx.com/csharp40/interfaces/cugi.htm
    /// 。interfaceとgenericの勉強のために、引用した。
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class GeometricShapes<T> : IShapes<T>
    {
        private int size;
        private T[] items;

        //コンストラクターに引数が無く、ジェネリック型のフィールドを定義していることには不安があるが、
        //そもそもジェネリック型を使用するクラスの場合、インスタンス生成時にジェネリック型<T>を定義するので、
        //問題ないようである。
        public GeometricShapes()
        {
            size = 0;
            items = new T[10];
        }

        public int Count { get { return size; } }

        public void Add(T item)
        {
            this.items[this.size] = item;
            this.size++;
        }

        //ジェネリック型を返すのも、普通に可能なようである。
        public T Get(int index) { return this.items[index]; }
    }




}
