//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.6.4
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from C:\Users\dotne\source\repos\spectnetide\v2\Assembler\AntlrZxBasicParserGenerator\AntlrZxBasicParserGenerator\ZxBasic.g4 by ANTLR 4.6.4

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace Spect.Net.BasicParser.Generated {

using Antlr4.Runtime.Misc;
using IErrorNode = Antlr4.Runtime.Tree.IErrorNode;
using ITerminalNode = Antlr4.Runtime.Tree.ITerminalNode;
using IToken = Antlr4.Runtime.IToken;
using ParserRuleContext = Antlr4.Runtime.ParserRuleContext;

/// <summary>
/// This class provides an empty implementation of <see cref="IZxBasicListener"/>,
/// which can be extended to create a listener which only needs to handle a subset
/// of the available methods.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.6.4")]
[System.CLSCompliant(false)]
public partial class ZxBasicBaseListener : IZxBasicListener {
	/// <summary>
	/// Enter a parse tree produced by <see cref="ZxBasicParser.compileUnit"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCompileUnit([NotNull] ZxBasicParser.CompileUnitContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="ZxBasicParser.compileUnit"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCompileUnit([NotNull] ZxBasicParser.CompileUnitContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="ZxBasicParser.label"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterLabel([NotNull] ZxBasicParser.LabelContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="ZxBasicParser.label"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitLabel([NotNull] ZxBasicParser.LabelContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="ZxBasicParser.line"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterLine([NotNull] ZxBasicParser.LineContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="ZxBasicParser.line"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitLine([NotNull] ZxBasicParser.LineContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="ZxBasicParser.line_item"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterLine_item([NotNull] ZxBasicParser.Line_itemContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="ZxBasicParser.line_item"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitLine_item([NotNull] ZxBasicParser.Line_itemContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="ZxBasicParser.asm_section"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAsm_section([NotNull] ZxBasicParser.Asm_sectionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="ZxBasicParser.asm_section"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAsm_section([NotNull] ZxBasicParser.Asm_sectionContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="ZxBasicParser.asm_start"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAsm_start([NotNull] ZxBasicParser.Asm_startContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="ZxBasicParser.asm_start"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAsm_start([NotNull] ZxBasicParser.Asm_startContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="ZxBasicParser.asm_body"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAsm_body([NotNull] ZxBasicParser.Asm_bodyContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="ZxBasicParser.asm_body"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAsm_body([NotNull] ZxBasicParser.Asm_bodyContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="ZxBasicParser.asm_end"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAsm_end([NotNull] ZxBasicParser.Asm_endContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="ZxBasicParser.asm_end"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAsm_end([NotNull] ZxBasicParser.Asm_endContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="ZxBasicParser.console"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterConsole([NotNull] ZxBasicParser.ConsoleContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="ZxBasicParser.console"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitConsole([NotNull] ZxBasicParser.ConsoleContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="ZxBasicParser.preproc"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPreproc([NotNull] ZxBasicParser.PreprocContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="ZxBasicParser.preproc"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPreproc([NotNull] ZxBasicParser.PreprocContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="ZxBasicParser.statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterStatement([NotNull] ZxBasicParser.StatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="ZxBasicParser.statement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitStatement([NotNull] ZxBasicParser.StatementContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="ZxBasicParser.control_flow"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterControl_flow([NotNull] ZxBasicParser.Control_flowContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="ZxBasicParser.control_flow"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitControl_flow([NotNull] ZxBasicParser.Control_flowContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="ZxBasicParser.function"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFunction([NotNull] ZxBasicParser.FunctionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="ZxBasicParser.function"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFunction([NotNull] ZxBasicParser.FunctionContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="ZxBasicParser.operator"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOperator([NotNull] ZxBasicParser.OperatorContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="ZxBasicParser.operator"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOperator([NotNull] ZxBasicParser.OperatorContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="ZxBasicParser.other"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOther([NotNull] ZxBasicParser.OtherContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="ZxBasicParser.other"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOther([NotNull] ZxBasicParser.OtherContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="ZxBasicParser.number"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterNumber([NotNull] ZxBasicParser.NumberContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="ZxBasicParser.number"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitNumber([NotNull] ZxBasicParser.NumberContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="ZxBasicParser.identifier"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterIdentifier([NotNull] ZxBasicParser.IdentifierContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="ZxBasicParser.identifier"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitIdentifier([NotNull] ZxBasicParser.IdentifierContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="ZxBasicParser.string"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterString([NotNull] ZxBasicParser.StringContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="ZxBasicParser.string"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitString([NotNull] ZxBasicParser.StringContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="ZxBasicParser.type"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterType([NotNull] ZxBasicParser.TypeContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="ZxBasicParser.type"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitType([NotNull] ZxBasicParser.TypeContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="ZxBasicParser.comment"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterComment([NotNull] ZxBasicParser.CommentContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="ZxBasicParser.comment"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitComment([NotNull] ZxBasicParser.CommentContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="ZxBasicParser.block_comment"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterBlock_comment([NotNull] ZxBasicParser.Block_commentContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="ZxBasicParser.block_comment"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitBlock_comment([NotNull] ZxBasicParser.Block_commentContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="ZxBasicParser.line_comment"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterLine_comment([NotNull] ZxBasicParser.Line_commentContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="ZxBasicParser.line_comment"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitLine_comment([NotNull] ZxBasicParser.Line_commentContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="ZxBasicParser.asm_token"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAsm_token([NotNull] ZxBasicParser.Asm_tokenContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="ZxBasicParser.asm_token"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAsm_token([NotNull] ZxBasicParser.Asm_tokenContext context) { }

	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void EnterEveryRule([NotNull] ParserRuleContext context) { }
	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void ExitEveryRule([NotNull] ParserRuleContext context) { }
	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void VisitTerminal([NotNull] ITerminalNode node) { }
	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void VisitErrorNode([NotNull] IErrorNode node) { }
}
} // namespace Spect.Net.BasicParser.Generated
