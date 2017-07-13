<Query Kind="Program" />

void Main()
{
    
	Func<int, bool> dlg = v => (v % 2) == 0;
	dlg.Dump();
		
	Expression<Func<int, bool>> exp = v => (v % 2) == 0; 
	exp.Dump();
	exp.Parameters[0].Name.Dump();
	exp.Body.Dump();

//  var でラムダ式を受けることはできない
//　　var some = v => (v % 2) == 0;

//  型が違うので代入できない
//  dlg = System.Func<int, bool>;
//  exp = System.Linq.Expressions.Expression<System.Func<int, bool>>;
//  exp = dlg;
//  dlg = exp;
}

//  ILSpyで見るとこうなってる
//	Func<int, bool> arg_20_0;
//	if ((arg_20_0 = CsvTest.<>c.<>9__4_0) == null)
//	{
//		CsvTest.<>c.<>9__4_0 = new Func<int, bool>(CsvTest.<>c.<>9.<Sample>b__4_0);
//	}
//	Expression<Func<int, bool>> exp = (int v) => v % 3 == 0;
