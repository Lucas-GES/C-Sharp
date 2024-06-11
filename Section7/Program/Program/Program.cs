using System.Diagnostics;
using System.Globalization;
using System;

class Program
{
    static void Main(string[] args)
    {
        int program = 7;
        switch (program)
        {
            case 1:
                UsingVar();
                break;
            case 2:
                UsingSwitchCase();
                break;
            case 3:
                UsingCondicionalTernaria();
                break;
            case 4:
                UsingFuncoesString();
                break;
            case 5:
                UsingDateTime();
                break;
            case 6:
                TimeSpan();
                break;
            case 7:
                UsingDateTimeKind();
                break;
            default:
                Console.WriteLine("Error 404");
                break;
        }
    }

    public static void UsingVar()
    {
        var x = 10;
        var y = 20.0;
        var z = "Luck";

        Console.WriteLine(x);
        Console.WriteLine(y);
        Console.WriteLine(z);
    }

    public static void UsingSwitchCase()
    {
        int x = int.Parse(Console.ReadLine());
        string day;
        switch (x)
        {
            case 1:
                day = "Sunday";
                break;
            case 2:
                day = "Monday";
                break;
            case 3:
                day = "Tuesday";
                break;
            case 4:
                day = "Wednesday";
                break;
            case 5:
                day = "Friday";
                break;
            case 6:
                day = "Saturday";
                break;
            default:
                day = "Invalid value";
                break;
        }

        Console.WriteLine("Day: " + day);
    }

    public static void UsingCondicionalTernaria()
    {
        double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        
        double desconto = (preco < 20.0) ? preco * 0.1 : preco * 0.05;
        
        Console.WriteLine(desconto);
    }

    public static void UsingFuncoesString()
    {
        string original = "abcde FGHIJ ABC abc DEFG     ";

        string s1 = original.ToUpper();
        string s2 = original.ToLower();
        string s3 = original.Trim();
        
        int n1 = original.IndexOf("bc");
        int n2 = original.LastIndexOf("bc");

        string s4 = original.Substring(3);
        string s5 = original.Substring(3, 5);
        string s6 = original.Replace('a', 'x');
        string s7 = original.Replace("abc", "xy");

        bool b1 = String.IsNullOrEmpty(original);
        bool b2 = String.IsNullOrWhiteSpace(original);

        Console.WriteLine("Original: -" + original + "-");
        Console.WriteLine("ToUpper: -" + s1 + "-");
        Console.WriteLine("ToLower: -" + s2 + "-");
        Console.WriteLine("Trim: -" + s3 + "-");
        Console.WriteLine("IndexOf('bc'): " + n1);
        Console.WriteLine("LastIndexOf('bc'): " + n2);
        Console.WriteLine("Substring(3): -" + s4 + "-");
        Console.WriteLine("Substring(3, 5): -" + s5 + "-");
        Console.WriteLine("Replace('a', 'x'): -" + s6 + "-");
        Console.WriteLine("Replace('abc', 'xy'): -" + s7 + "-");
        Console.WriteLine("IsNullOrEmpty: " + b1);
        Console.WriteLine("IsNullOrWhiteSpace: " + b2);
    }

    public   static void UsingDateTime()
    {
        DateTime d1 = DateTime.Now;
        Console.WriteLine(d1);
        Console.WriteLine(d1.Ticks);

        DateTime d2 = new DateTime(2018, 11, 25);
        DateTime d3 = new DateTime(2018, 11, 25, 20, 45, 3);
        DateTime d4 = new DateTime(2018, 11, 25, 20, 45, 3, 500);

        DateTime d5 = DateTime.Today;
        DateTime d6 = DateTime.UtcNow;

        DateTime d7 = DateTime.Parse("2000-08-15");
        DateTime d8 = DateTime.Parse("2000-08-15 13:05:58");
        DateTime d9 = DateTime.Parse("15/08/2000");
        DateTime d10 = DateTime.Parse("15/08/2000 13:05:58");

        DateTime d11 = DateTime.ParseExact("2000-08-15", "yyyy-MM-dd", CultureInfo.InvariantCulture);
        DateTime d12 = DateTime.ParseExact("15/08/2000 13:05:58", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);

        Console.WriteLine(d2);
        Console.WriteLine(d3);
        Console.WriteLine(d4);
        Console.WriteLine(d5);
        Console.WriteLine(d6);
        Console.WriteLine(d7);
        Console.WriteLine(d8);
        Console.WriteLine(d9);
        Console.WriteLine(d10);
        Console.WriteLine(d11);
        Console.WriteLine(d12);

        // Part 2

        Console.WriteLine("----------- Part 2 ----------");
        DateTime d = new DateTime(2001, 8, 15, 13, 45, 58, 275);

        Console.WriteLine(d);
        Console.WriteLine("1) Date: " + d.Date);
        Console.WriteLine("2) Day: " + d.Day);
        Console.WriteLine("3) DayOfWeek: " + d.DayOfWeek);
        Console.WriteLine("4) DayOfYear: " + d.DayOfYear);
        Console.WriteLine("5) Hour: " + d.Hour);
        Console.WriteLine("6) Kind: " + d.Kind);
        Console.WriteLine("7) Millisecond: " + d.Millisecond);
        Console.WriteLine("8) Minute: " + d.Minute);
        Console.WriteLine("9) Month: " + d.Month);
        Console.WriteLine("10) Second: " + d.Second);
        Console.WriteLine("11) Ticks: " + d.Ticks);
        Console.WriteLine("12) TimeOfDay: " + d.TimeOfDay);
        Console.WriteLine("13) Year: " + d.Year);

        Console.WriteLine("----------- Part 3 ----------");
        string s1 = d.ToLongDateString();
        string s2 = d.ToLongTimeString();
        string s3 = d.ToShortDateString();
        string s4 = d.ToShortTimeString();
        string s5 = d.ToString();
        string s6 = d.ToString("yyyy-MM-dd HH:mm:ss");
        string s7 = d.ToString("yyyy-MM-dd HH:mm:ss.fff");

        Console.WriteLine(s1);
        Console.WriteLine(s2);
        Console.WriteLine(s3);
        Console.WriteLine(s4);
        Console.WriteLine(s5);
        Console.WriteLine(s6);
        Console.WriteLine(s7);

        d = new DateTime(2001, 8, 15, 13, 45, 58);
        d2 = d.AddHours(2);
        d3 = d.AddMinutes(3);
        d4 = d.AddDays(7);

        Console.WriteLine(d);
        Console.WriteLine(d2);
        Console.WriteLine(d3);
        Console.WriteLine(d4);

    }

    public static void TimeSpan()
    {
        TimeSpan t1 = new TimeSpan();
        TimeSpan t2 = new TimeSpan(900000000L);
        TimeSpan t3 = new TimeSpan(2, 11, 21);
        TimeSpan t4 = new TimeSpan(1, 2, 11, 21);
        TimeSpan t5 = new TimeSpan(1, 2, 11, 21, 321);

        TimeSpan t6 = System.TimeSpan.FromDays(1.5);
        TimeSpan t7 = System.TimeSpan.FromHours(1.5);
        TimeSpan t8 = System.TimeSpan.FromMinutes(1.5);
        TimeSpan t9 = System.TimeSpan.FromSeconds(1.5);
        TimeSpan t10 = System.TimeSpan.FromMilliseconds(1.5);
        TimeSpan t11 = System.TimeSpan.FromTicks(900000000L);

        Console.WriteLine(t1);
        Console.WriteLine(t2);
        Console.WriteLine(t3);
        Console.WriteLine(t4);
        Console.WriteLine(t5);
        Console.WriteLine(t6);
        Console.WriteLine(t7);
        Console.WriteLine(t8);
        Console.WriteLine(t9);
        Console.WriteLine(t10);
        Console.WriteLine(t11);
        
        Console.WriteLine("------------ Part 2 --------------");
        t1 = System.TimeSpan.MaxValue;
        t2 = System.TimeSpan.MinValue;
        t3 = System.TimeSpan.Zero;

        Console.WriteLine(t1);
        Console.WriteLine(t2);
        Console.WriteLine(t3);

        TimeSpan t = new TimeSpan(2, 3, 5, 7, 11);

        Console.WriteLine(t);
        Console.WriteLine("Days: " + t.Days);

        Console.WriteLine("Hours: " + t.Hours);

        Console.WriteLine("Minutes: " + t.Minutes);

        Console.WriteLine("Milliseconds: " + t.Milliseconds);

        Console.WriteLine("Seconds: " + t.Seconds);

        Console.WriteLine("Ticks: " + t.Ticks);

        Console.WriteLine("TotalDays: " + t.TotalDays);

        Console.WriteLine("TotalHours: " + t.TotalHours);

        Console.WriteLine("TotalMinutes: " + t.TotalMinutes);

        Console.WriteLine("TotalSeconds: " + t.TotalSeconds);

        Console.WriteLine("TotalMilliseconds: " + t.TotalMilliseconds);

        Console.WriteLine("------------ Part 3 --------------");
        t1 = new TimeSpan(1, 30, 10);
        t2 = new TimeSpan(0, 10, 5);

        TimeSpan soma = t1.Add(t2);
        TimeSpan dif = t1.Subtract(t2);
        TimeSpan mult = t2.Multiply(2.0);
        TimeSpan div = t2.Divide(2.0);
        Console.WriteLine(soma);
        Console.WriteLine(dif);
        Console.WriteLine(div);
        Console.WriteLine(mult);
    }
    
    public static void UsingDateTimeKind()
    {
        DateTime t1 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Local);

        DateTime t2 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Utc);

        DateTime t3 = new DateTime(2000, 8, 15, 13, 5, 58);

        Console.WriteLine("t1: " + t1);
        Console.WriteLine("t1 Kind: " + t1.Kind);
        Console.WriteLine("t1 to Local: " + t1.ToLocalTime());
        Console.WriteLine("t1 to Utc: " + t1.ToUniversalTime());
        Console.WriteLine();
        Console.WriteLine("t2: " + t2);
        Console.WriteLine("t2 Kind: " + t2.Kind);
        Console.WriteLine("t2 to Local: " + t2.ToLocalTime());
        Console.WriteLine("t2 to Utc: " + t2.ToUniversalTime());
        Console.WriteLine();
        Console.WriteLine("t3: " + t3);
        Console.WriteLine("t3 Kind: " + t3.Kind);
        Console.WriteLine("t3 to Local: " + t3.ToLocalTime());
        Console.WriteLine("t3 to Utc: " + t3.ToUniversalTime());
        Console.WriteLine();

        DateTime d1 = DateTime.Parse("2000-08-15 13:05:58");
        DateTime d2 = DateTime.Parse("2000-08-15T13:05:58Z");

        Console.WriteLine("d1: " + d1);
        Console.WriteLine("d1 Kind: " + d1.Kind);
        Console.WriteLine("d1 to Local: " + d1.ToLocalTime());
        Console.WriteLine("d1 to Utc: " + d1.ToUniversalTime());
        Console.WriteLine();
        Console.WriteLine("d2: " + d2);
        Console.WriteLine("d2 Kind: " + d2.Kind);
        Console.WriteLine("d2 to Local: " + d2.ToLocalTime());
        Console.WriteLine("d2 to Utc: " + d2.ToUniversalTime());
        Console.WriteLine();
        Console.WriteLine(d2.ToString("yyyy-MM-ddTHH:mm:ssZ")); // Danger
        Console.WriteLine(d2.ToUniversalTime().ToString("yyyy-MM-ddTHH:mm:ssZ"));
    }
}