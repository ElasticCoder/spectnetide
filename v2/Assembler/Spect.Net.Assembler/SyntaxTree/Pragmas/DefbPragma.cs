using System.Collections.Generic;
using Antlr4.Runtime.Tree;
using Spect.Net.Assembler.SyntaxTree.Expressions;

namespace Spect.Net.Assembler.SyntaxTree.Pragmas
{
    /// <summary>
    /// This class represents the DEFB pragma
    /// </summary>
    public sealed class DefbPragma : PragmaBase, ISupportsFieldAssignment
    {
        /// <summary>
        /// The bytes to define
        /// </summary>
        public List<ExpressionNode> Exprs { get; }

        /// <summary>
        /// True indicates that this node is used within a field assignment
        /// </summary>
        public bool IsFieldAssignment { get; set; }

        public DefbPragma(IZ80AsmVisitorContext visitorContext, IParseTree context)
        {
            Exprs = new List<ExpressionNode>();
            for (var i = 1; i < context.ChildCount; i += 2)
            {
                Exprs.Add(visitorContext.GetExpression(context.GetChild(i)));
            }
        }
    }
}