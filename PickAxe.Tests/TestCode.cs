﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using HtmlAgilityPack;
using Pickaxe.Runtime;
using System;
using System.Collections.Generic;
using System.Linq;



public class Code : RuntimeBase
{

    private Scope_4b82c128bca34f3eb18682c8acc81ed2 _Scope_4b82c128bca34f3eb18682c8acc81ed2;

    private Scope_d107457680b74e1fb2184fb9fdc5f6ba _Scope_d107457680b74e1fb2184fb9fdc5f6ba;

    public Code(string[] args) :
        base(args)
    {
        _Scope_4b82c128bca34f3eb18682c8acc81ed2 = new Scope_4b82c128bca34f3eb18682c8acc81ed2();
        _Scope_d107457680b74e1fb2184fb9fdc5f6ba = new Scope_d107457680b74e1fb2184fb9fdc5f6ba();
        TotalOperations = (TotalOperations + 1);
    }

    public void Run()
    {
        InitProxies();
        Block_1a35585eddcc44c8a5f162c02d03eeae();
        Step_c7713449e7c245cf8e389b7a0ffce92b();
    }

    public void Block_1a35585eddcc44c8a5f162c02d03eeae()
    {
        Step_321c203d24fd49929cf53d8057257997();
    }

    private CodeTable<anon_e77da3131e1d4cf1970c18c99c04c921> From_063aa67f80e6401686b3f3c73c24dfc4()
    {
        Call(6);
        IEnumerable<anon_e77da3131e1d4cf1970c18c99c04c921> join = Fetch_2c215013122d4959a2b1249ba18fc3a2();
        CodeTable<anon_e77da3131e1d4cf1970c18c99c04c921> newTable = new CodeTable<anon_e77da3131e1d4cf1970c18c99c04c921>();
        newTable.SetRows(join.ToList());
        return newTable;
    }

    private RuntimeTable<DownloadPage> Download_2117f33972ca4c7ba59158848fe86a7f()
    {
        Call(6);
        return new SelectDownloadTable(Pickaxe.Runtime.LazyDownloadArgs.CreateWebRequestArgs(this, 6, 1, "http://www.target.com/c/deli-grocery-essentials/-/N-5hp74#?lnk=lnav_shop categori" +
                    "es_13&intc=2776003|null"));
    }

    private IEnumerable<anon_e77da3131e1d4cf1970c18c99c04c921> Fetch_2c215013122d4959a2b1249ba18fc3a2()
    {
        RuntimeTable<DownloadPage> table = Download_2117f33972ca4c7ba59158848fe86a7f();
        return table.Select(o =>
        {
            return Copy_3518e41cd8c542228a7c331cd51d1cda(o);
        });
    }

    private anon_e77da3131e1d4cf1970c18c99c04c921 Copy_3518e41cd8c542228a7c331cd51d1cda(DownloadPage o)
    {
        anon_e77da3131e1d4cf1970c18c99c04c921 t = new anon_e77da3131e1d4cf1970c18c99c04c921();
        t.DownloadPage = o;
        return t;
    }

    private Table<ResultRow> Select_6ea90561ec26483685c68cc37a476cfa()
    {
        Call(3);
        RuntimeTable<ResultRow> result = new RuntimeTable<ResultRow>();
        result.AddColumn("url");
        result.AddColumn("(No column name)");
        CodeTable<anon_e77da3131e1d4cf1970c18c99c04c921> fromTable = From_063aa67f80e6401686b3f3c73c24dfc4();
        fromTable = Where_18735c6e301a42d68fee5c66fc258c09(fromTable);
        IEnumerator<anon_e77da3131e1d4cf1970c18c99c04c921> x = fromTable.GetEnumerator();
        for (
        ; x.MoveNext();
        )
        {
            anon_e77da3131e1d4cf1970c18c99c04c921 row = x.Current;
            IEnumerator<HtmlNode> y = row.DownloadPage.nodes.GetEnumerator();
            for (
            ; y.MoveNext();
            )
            {
                HtmlNode node = y.Current;
                ResultRow resultRow = new ResultRow(2);
                resultRow[0] = row.DownloadPage.url;
                resultRow[1] = string.Concat("http://www.target.com", node.Pick("a:first-child").TakeAttribute("href"));
                if (((resultRow[0] != null)
                            && (resultRow[1] != null)))
                {
                    result.Add(resultRow);
                }
            }
            row.DownloadPage.Clear();
        }
        OnSelect(result);
        return result;
    }

    private CodeTable<anon_e77da3131e1d4cf1970c18c99c04c921> Where_18735c6e301a42d68fee5c66fc258c09(CodeTable<anon_e77da3131e1d4cf1970c18c99c04c921> table)
    {
        Call(7);
        CodeTable<anon_e77da3131e1d4cf1970c18c99c04c921> newTable = new CodeTable<anon_e77da3131e1d4cf1970c18c99c04c921>();
        IList<anon_e77da3131e1d4cf1970c18c99c04c921> rows = table.Where(row =>
        {
            return true;
        }).ToList();
        newTable.SetRows(rows);
        IEnumerator<anon_e77da3131e1d4cf1970c18c99c04c921> i = newTable.GetEnumerator();
        for (
        ; i.MoveNext();
        )
        {
            anon_e77da3131e1d4cf1970c18c99c04c921 row = i.Current;
            row.DownloadPage = row.DownloadPage.CssWhere("ul.brandlist li");
        }
        return newTable;
    }

    public void Step_321c203d24fd49929cf53d8057257997()
    {
        Select_6ea90561ec26483685c68cc37a476cfa();
        OnProgress();
    }

    public void Step_c7713449e7c245cf8e389b7a0ffce92b()
    {
        OnProgress(new ProgressArgs(TotalOperations, TotalOperations));
    }

    private class Scope_4b82c128bca34f3eb18682c8acc81ed2
    {

        public int g_identity;

        public Scope_4b82c128bca34f3eb18682c8acc81ed2()
        {
        }
    }

    private class Scope_d107457680b74e1fb2184fb9fdc5f6ba
    {

        public Scope_d107457680b74e1fb2184fb9fdc5f6ba()
        {
        }
    }

    private class anon_e77da3131e1d4cf1970c18c99c04c921 : IRow
    {

        public DownloadPage DownloadPage;
    }
}
