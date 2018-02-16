//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.6.4
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from C:\Users\dotne\source\repos\spectnetide\Assembler\AntlrZ80TestParserGenerator\AntlrZ80TestParserGenerator\Z80Test.g4 by ANTLR 4.6.4

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace Spect.Net.TestParser.Generated {
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using IToken = Antlr4.Runtime.IToken;
using ParserRuleContext = Antlr4.Runtime.ParserRuleContext;

/// <summary>
/// This class provides an empty implementation of <see cref="IZ80TestVisitor{Result}"/>,
/// which can be extended to create a visitor which only needs to handle a subset
/// of the available methods.
/// </summary>
/// <typeparam name="Result">The return type of the visit operation.</typeparam>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.6.4")]
[System.CLSCompliant(false)]
public partial class Z80TestBaseVisitor<Result> : AbstractParseTreeVisitor<Result>, IZ80TestVisitor<Result> {
	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80TestParser.compileUnit"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitCompileUnit([NotNull] Z80TestParser.CompileUnitContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80TestParser.testSet"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitTestSet([NotNull] Z80TestParser.TestSetContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80TestParser.sourceContext"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitSourceContext([NotNull] Z80TestParser.SourceContextContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80TestParser.callstub"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitCallstub([NotNull] Z80TestParser.CallstubContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80TestParser.testOptions"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitTestOptions([NotNull] Z80TestParser.TestOptionsContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80TestParser.testOption"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitTestOption([NotNull] Z80TestParser.TestOptionContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80TestParser.dataBlock"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitDataBlock([NotNull] Z80TestParser.DataBlockContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80TestParser.dataBlockBody"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitDataBlockBody([NotNull] Z80TestParser.DataBlockBodyContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80TestParser.valueDef"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitValueDef([NotNull] Z80TestParser.ValueDefContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80TestParser.memPattern"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitMemPattern([NotNull] Z80TestParser.MemPatternContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80TestParser.memPatternBody"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitMemPatternBody([NotNull] Z80TestParser.MemPatternBodyContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80TestParser.byteSet"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitByteSet([NotNull] Z80TestParser.ByteSetContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80TestParser.wordSet"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitWordSet([NotNull] Z80TestParser.WordSetContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80TestParser.text"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitText([NotNull] Z80TestParser.TextContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80TestParser.portMock"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitPortMock([NotNull] Z80TestParser.PortMockContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80TestParser.portPulse"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitPortPulse([NotNull] Z80TestParser.PortPulseContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80TestParser.initSettings"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitInitSettings([NotNull] Z80TestParser.InitSettingsContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80TestParser.setupCode"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitSetupCode([NotNull] Z80TestParser.SetupCodeContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80TestParser.cleanupCode"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitCleanupCode([NotNull] Z80TestParser.CleanupCodeContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80TestParser.invokeCode"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitInvokeCode([NotNull] Z80TestParser.InvokeCodeContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80TestParser.testBlock"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitTestBlock([NotNull] Z80TestParser.TestBlockContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80TestParser.testParams"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitTestParams([NotNull] Z80TestParser.TestParamsContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80TestParser.testCase"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitTestCase([NotNull] Z80TestParser.TestCaseContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80TestParser.arrange"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitArrange([NotNull] Z80TestParser.ArrangeContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80TestParser.assignment"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitAssignment([NotNull] Z80TestParser.AssignmentContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80TestParser.regAssignment"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitRegAssignment([NotNull] Z80TestParser.RegAssignmentContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80TestParser.flagStatus"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitFlagStatus([NotNull] Z80TestParser.FlagStatusContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80TestParser.memAssignment"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitMemAssignment([NotNull] Z80TestParser.MemAssignmentContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80TestParser.act"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitAct([NotNull] Z80TestParser.ActContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80TestParser.breakpoint"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitBreakpoint([NotNull] Z80TestParser.BreakpointContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80TestParser.assert"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitAssert([NotNull] Z80TestParser.AssertContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80TestParser.reg8"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitReg8([NotNull] Z80TestParser.Reg8Context context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80TestParser.reg8Idx"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitReg8Idx([NotNull] Z80TestParser.Reg8IdxContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80TestParser.reg8Spec"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitReg8Spec([NotNull] Z80TestParser.Reg8SpecContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80TestParser.reg16"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitReg16([NotNull] Z80TestParser.Reg16Context context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80TestParser.reg16Idx"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitReg16Idx([NotNull] Z80TestParser.Reg16IdxContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80TestParser.reg16Spec"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitReg16Spec([NotNull] Z80TestParser.Reg16SpecContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80TestParser.flag"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitFlag([NotNull] Z80TestParser.FlagContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80TestParser.expr"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitExpr([NotNull] Z80TestParser.ExprContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80TestParser.orExpr"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitOrExpr([NotNull] Z80TestParser.OrExprContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80TestParser.xorExpr"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitXorExpr([NotNull] Z80TestParser.XorExprContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80TestParser.andExpr"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitAndExpr([NotNull] Z80TestParser.AndExprContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80TestParser.equExpr"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitEquExpr([NotNull] Z80TestParser.EquExprContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80TestParser.relExpr"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitRelExpr([NotNull] Z80TestParser.RelExprContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80TestParser.shiftExpr"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitShiftExpr([NotNull] Z80TestParser.ShiftExprContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80TestParser.addExpr"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitAddExpr([NotNull] Z80TestParser.AddExprContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80TestParser.multExpr"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitMultExpr([NotNull] Z80TestParser.MultExprContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80TestParser.unaryExpr"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitUnaryExpr([NotNull] Z80TestParser.UnaryExprContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80TestParser.literalExpr"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitLiteralExpr([NotNull] Z80TestParser.LiteralExprContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80TestParser.symbolExpr"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitSymbolExpr([NotNull] Z80TestParser.SymbolExprContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80TestParser.registerSpec"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitRegisterSpec([NotNull] Z80TestParser.RegisterSpecContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80TestParser.addrSpec"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitAddrSpec([NotNull] Z80TestParser.AddrSpecContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="Z80TestParser.reachSpec"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitReachSpec([NotNull] Z80TestParser.ReachSpecContext context) { return VisitChildren(context); }
}
} // namespace Spect.Net.TestParser.Generated
