using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace ExpressionTrees
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryExpression b1 = Expression.MakeBinary(ExpressionType.Add, Expression.Constant(10), Expression.Constant(70));
            BinaryExpression b2 = Expression.MakeBinary(ExpressionType.Add, Expression.Constant(20), Expression.Constant(30));
            BinaryExpression b3 = Expression.MakeBinary(ExpressionType.Subtract, b1, b2);
            int result = Expression.Lambda<Func<int>>(b3).Compile()();
            Console.WriteLine(result);
            Console.ReadKey();

        }
    }
}
