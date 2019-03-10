//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.6.6
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from C:\Users\dotne\source\repos\spectnetide\Assembler\AntlrCommandParserGenerator\AntlrCommandParserGenerator\CommandTool.g4 by ANTLR 4.6.6

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace Spect.Net.CommandParser.Generated {
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.6.6")]
[System.CLSCompliant(false)]
public partial class CommandToolLexer : Lexer {
	public const int
		WS=1, LESS=2, LESSEQ=3, GREAT=4, GREATEQ=5, EQ=6, MULT=7, HASH=8, ADD=9, 
		DASH=10, COLON=11, B=12, C=13, D=14, EB=15, EW=16, G=17, GS=18, G1=19, 
		G2=20, G3=21, G4=22, H=23, J=24, L=25, LW=26, M=27, P=28, R=29, RD=30, 
		S=31, SB=32, T=33, TB=34, RB=35, UB=36, XD=37, XW=38, W=39, RETRIEVE=40, 
		SECTION=41, LITERAL=42, LITCH=43, OTHER=44;
	public static string[] modeNames = {
		"DEFAULT_MODE"
	};

	public static readonly string[] ruleNames = {
		"WS", "LESS", "LESSEQ", "GREAT", "GREATEQ", "EQ", "MULT", "HASH", "ADD", 
		"DASH", "COLON", "B", "C", "D", "EB", "EW", "G", "GS", "G1", "G2", "G3", 
		"G4", "H", "J", "L", "LW", "M", "P", "R", "RD", "S", "SB", "T", "TB", 
		"RB", "UB", "XD", "XW", "W", "RETRIEVE", "SECTION", "LITERAL", "LITCH", 
		"OTHER"
	};


	public CommandToolLexer(ICharStream input)
		: base(input)
	{
		_interp = new LexerATNSimulator(this,_ATN);
	}

	private static readonly string[] _LiteralNames = {
		null, null, "'<'", "'<='", "'>'", "'>='", "'='", "'*'", "'#'", "'+'", 
		"'-'", "':'"
	};
	private static readonly string[] _SymbolicNames = {
		null, "WS", "LESS", "LESSEQ", "GREAT", "GREATEQ", "EQ", "MULT", "HASH", 
		"ADD", "DASH", "COLON", "B", "C", "D", "EB", "EW", "G", "GS", "G1", "G2", 
		"G3", "G4", "H", "J", "L", "LW", "M", "P", "R", "RD", "S", "SB", "T", 
		"TB", "RB", "UB", "XD", "XW", "W", "RETRIEVE", "SECTION", "LITERAL", "LITCH", 
		"OTHER"
	};
	public static readonly IVocabulary DefaultVocabulary = new Vocabulary(_LiteralNames, _SymbolicNames);

	[System.Obsolete("Use Vocabulary instead.")]
	public static readonly string[] tokenNames = GenerateTokenNames(DefaultVocabulary, _SymbolicNames.Length);

	private static string[] GenerateTokenNames(IVocabulary vocabulary, int length) {
		string[] tokenNames = new string[length];
		for (int i = 0; i < tokenNames.Length; i++) {
			tokenNames[i] = vocabulary.GetLiteralName(i);
			if (tokenNames[i] == null) {
				tokenNames[i] = vocabulary.GetSymbolicName(i);
			}

			if (tokenNames[i] == null) {
				tokenNames[i] = "<INVALID>";
			}
		}

		return tokenNames;
	}

	[System.Obsolete("Use IRecognizer.Vocabulary instead.")]
	public override string[] TokenNames
	{
		get
		{
			return tokenNames;
		}
	}

	[NotNull]
	public override IVocabulary Vocabulary
	{
		get
		{
			return DefaultVocabulary;
		}
	}

	public override string GrammarFileName { get { return "CommandTool.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string[] ModeNames { get { return modeNames; } }

	public override string SerializedAtn { get { return _serializedATN; } }

	public static readonly string _serializedATN =
		"\x3\xAF6F\x8320\x479D\xB75C\x4880\x1605\x191C\xAB37\x2.\x135\b\x1\x4\x2"+
		"\t\x2\x4\x3\t\x3\x4\x4\t\x4\x4\x5\t\x5\x4\x6\t\x6\x4\a\t\a\x4\b\t\b\x4"+
		"\t\t\t\x4\n\t\n\x4\v\t\v\x4\f\t\f\x4\r\t\r\x4\xE\t\xE\x4\xF\t\xF\x4\x10"+
		"\t\x10\x4\x11\t\x11\x4\x12\t\x12\x4\x13\t\x13\x4\x14\t\x14\x4\x15\t\x15"+
		"\x4\x16\t\x16\x4\x17\t\x17\x4\x18\t\x18\x4\x19\t\x19\x4\x1A\t\x1A\x4\x1B"+
		"\t\x1B\x4\x1C\t\x1C\x4\x1D\t\x1D\x4\x1E\t\x1E\x4\x1F\t\x1F\x4 \t \x4!"+
		"\t!\x4\"\t\"\x4#\t#\x4$\t$\x4%\t%\x4&\t&\x4\'\t\'\x4(\t(\x4)\t)\x4*\t"+
		"*\x4+\t+\x4,\t,\x4-\t-\x3\x2\x6\x2]\n\x2\r\x2\xE\x2^\x3\x3\x3\x3\x3\x4"+
		"\x3\x4\x3\x4\x3\x5\x3\x5\x3\x6\x3\x6\x3\x6\x3\a\x3\a\x3\b\x3\b\x3\t\x3"+
		"\t\x3\n\x3\n\x3\v\x3\v\x3\f\x3\f\x3\r\x3\r\x3\xE\x3\xE\x3\xF\x3\xF\x3"+
		"\x10\x3\x10\x3\x10\x3\x10\x3\x10\x3\x10\x3\x10\x3\x10\x5\x10\x85\n\x10"+
		"\x3\x11\x3\x11\x3\x11\x3\x11\x3\x11\x3\x11\x3\x11\x3\x11\x5\x11\x8F\n"+
		"\x11\x3\x12\x3\x12\x3\x13\x3\x13\x3\x13\x3\x13\x3\x13\x3\x13\x3\x13\x3"+
		"\x13\x5\x13\x9B\n\x13\x3\x14\x3\x14\x3\x14\x3\x14\x5\x14\xA1\n\x14\x3"+
		"\x15\x3\x15\x3\x15\x3\x15\x5\x15\xA7\n\x15\x3\x16\x3\x16\x3\x16\x3\x16"+
		"\x5\x16\xAD\n\x16\x3\x17\x3\x17\x3\x17\x3\x17\x5\x17\xB3\n\x17\x3\x18"+
		"\x3\x18\x3\x19\x3\x19\x3\x1A\x3\x1A\x3\x1B\x3\x1B\x3\x1B\x3\x1B\x3\x1B"+
		"\x3\x1B\x3\x1B\x3\x1B\x5\x1B\xC3\n\x1B\x3\x1C\x3\x1C\x3\x1D\x3\x1D\x3"+
		"\x1E\x3\x1E\x3\x1F\x3\x1F\x3\x1F\x3\x1F\x3\x1F\x3\x1F\x3\x1F\x3\x1F\x5"+
		"\x1F\xD3\n\x1F\x3 \x3 \x3!\x3!\x3!\x3!\x3!\x3!\x3!\x3!\x5!\xDF\n!\x3\""+
		"\x3\"\x3#\x3#\x3#\x3#\x3#\x3#\x3#\x3#\x5#\xEB\n#\x3$\x3$\x3$\x3$\x3$\x3"+
		"$\x3$\x3$\x5$\xF5\n$\x3%\x3%\x3%\x3%\x3%\x3%\x3%\x3%\x5%\xFF\n%\x3&\x3"+
		"&\x3&\x3&\x3&\x3&\x3&\x3&\x5&\x109\n&\x3\'\x3\'\x3\'\x3\'\x3\'\x3\'\x3"+
		"\'\x3\'\x5\'\x113\n\'\x3(\x3(\x3)\x3)\x3)\x3)\x5)\x11B\n)\x3*\x3*\x3*"+
		"\x3*\x3*\x3*\x3*\x3*\x3*\x3*\x3*\x5*\x128\n*\x3+\x5+\x12B\n+\x3+\x6+\x12E"+
		"\n+\r+\xE+\x12F\x3,\x3,\x3-\x3-\x2\x2\x2.\x3\x2\x3\x5\x2\x4\a\x2\x5\t"+
		"\x2\x6\v\x2\a\r\x2\b\xF\x2\t\x11\x2\n\x13\x2\v\x15\x2\f\x17\x2\r\x19\x2"+
		"\xE\x1B\x2\xF\x1D\x2\x10\x1F\x2\x11!\x2\x12#\x2\x13%\x2\x14\'\x2\x15)"+
		"\x2\x16+\x2\x17-\x2\x18/\x2\x19\x31\x2\x1A\x33\x2\x1B\x35\x2\x1C\x37\x2"+
		"\x1D\x39\x2\x1E;\x2\x1F=\x2 ?\x2!\x41\x2\"\x43\x2#\x45\x2$G\x2%I\x2&K"+
		"\x2\'M\x2(O\x2)Q\x2*S\x2+U\x2,W\x2-Y\x2.\x3\x2\x11\x4\x2\v\v\"\"\x4\x2"+
		"\x44\x44\x64\x64\x4\x2\x45\x45\x65\x65\x4\x2\x46\x46\x66\x66\x4\x2IIi"+
		"i\x4\x2JJjj\x4\x2LLll\x4\x2NNnn\x4\x2OOoo\x4\x2RRrr\x4\x2TTtt\x4\x2UU"+
		"uu\x4\x2VVvv\x4\x2YYyy\b\x2##%%\x32;\x41\\\x61\x61\x63|\x167\x2\x3\x3"+
		"\x2\x2\x2\x2\x5\x3\x2\x2\x2\x2\a\x3\x2\x2\x2\x2\t\x3\x2\x2\x2\x2\v\x3"+
		"\x2\x2\x2\x2\r\x3\x2\x2\x2\x2\xF\x3\x2\x2\x2\x2\x11\x3\x2\x2\x2\x2\x13"+
		"\x3\x2\x2\x2\x2\x15\x3\x2\x2\x2\x2\x17\x3\x2\x2\x2\x2\x19\x3\x2\x2\x2"+
		"\x2\x1B\x3\x2\x2\x2\x2\x1D\x3\x2\x2\x2\x2\x1F\x3\x2\x2\x2\x2!\x3\x2\x2"+
		"\x2\x2#\x3\x2\x2\x2\x2%\x3\x2\x2\x2\x2\'\x3\x2\x2\x2\x2)\x3\x2\x2\x2\x2"+
		"+\x3\x2\x2\x2\x2-\x3\x2\x2\x2\x2/\x3\x2\x2\x2\x2\x31\x3\x2\x2\x2\x2\x33"+
		"\x3\x2\x2\x2\x2\x35\x3\x2\x2\x2\x2\x37\x3\x2\x2\x2\x2\x39\x3\x2\x2\x2"+
		"\x2;\x3\x2\x2\x2\x2=\x3\x2\x2\x2\x2?\x3\x2\x2\x2\x2\x41\x3\x2\x2\x2\x2"+
		"\x43\x3\x2\x2\x2\x2\x45\x3\x2\x2\x2\x2G\x3\x2\x2\x2\x2I\x3\x2\x2\x2\x2"+
		"K\x3\x2\x2\x2\x2M\x3\x2\x2\x2\x2O\x3\x2\x2\x2\x2Q\x3\x2\x2\x2\x2S\x3\x2"+
		"\x2\x2\x2U\x3\x2\x2\x2\x2W\x3\x2\x2\x2\x2Y\x3\x2\x2\x2\x3\\\x3\x2\x2\x2"+
		"\x5`\x3\x2\x2\x2\a\x62\x3\x2\x2\x2\t\x65\x3\x2\x2\x2\vg\x3\x2\x2\x2\r"+
		"j\x3\x2\x2\x2\xFl\x3\x2\x2\x2\x11n\x3\x2\x2\x2\x13p\x3\x2\x2\x2\x15r\x3"+
		"\x2\x2\x2\x17t\x3\x2\x2\x2\x19v\x3\x2\x2\x2\x1Bx\x3\x2\x2\x2\x1Dz\x3\x2"+
		"\x2\x2\x1F\x84\x3\x2\x2\x2!\x8E\x3\x2\x2\x2#\x90\x3\x2\x2\x2%\x9A\x3\x2"+
		"\x2\x2\'\xA0\x3\x2\x2\x2)\xA6\x3\x2\x2\x2+\xAC\x3\x2\x2\x2-\xB2\x3\x2"+
		"\x2\x2/\xB4\x3\x2\x2\x2\x31\xB6\x3\x2\x2\x2\x33\xB8\x3\x2\x2\x2\x35\xC2"+
		"\x3\x2\x2\x2\x37\xC4\x3\x2\x2\x2\x39\xC6\x3\x2\x2\x2;\xC8\x3\x2\x2\x2"+
		"=\xD2\x3\x2\x2\x2?\xD4\x3\x2\x2\x2\x41\xDE\x3\x2\x2\x2\x43\xE0\x3\x2\x2"+
		"\x2\x45\xEA\x3\x2\x2\x2G\xF4\x3\x2\x2\x2I\xFE\x3\x2\x2\x2K\x108\x3\x2"+
		"\x2\x2M\x112\x3\x2\x2\x2O\x114\x3\x2\x2\x2Q\x116\x3\x2\x2\x2S\x11C\x3"+
		"\x2\x2\x2U\x12A\x3\x2\x2\x2W\x131\x3\x2\x2\x2Y\x133\x3\x2\x2\x2[]\t\x2"+
		"\x2\x2\\[\x3\x2\x2\x2]^\x3\x2\x2\x2^\\\x3\x2\x2\x2^_\x3\x2\x2\x2_\x4\x3"+
		"\x2\x2\x2`\x61\a>\x2\x2\x61\x6\x3\x2\x2\x2\x62\x63\a>\x2\x2\x63\x64\a"+
		"?\x2\x2\x64\b\x3\x2\x2\x2\x65\x66\a@\x2\x2\x66\n\x3\x2\x2\x2gh\a@\x2\x2"+
		"hi\a?\x2\x2i\f\x3\x2\x2\x2jk\a?\x2\x2k\xE\x3\x2\x2\x2lm\a,\x2\x2m\x10"+
		"\x3\x2\x2\x2no\a%\x2\x2o\x12\x3\x2\x2\x2pq\a-\x2\x2q\x14\x3\x2\x2\x2r"+
		"s\a/\x2\x2s\x16\x3\x2\x2\x2tu\a<\x2\x2u\x18\x3\x2\x2\x2vw\t\x3\x2\x2w"+
		"\x1A\x3\x2\x2\x2xy\t\x4\x2\x2y\x1C\x3\x2\x2\x2z{\t\x5\x2\x2{\x1E\x3\x2"+
		"\x2\x2|}\ag\x2\x2}\x85\a\x64\x2\x2~\x7F\ag\x2\x2\x7F\x85\a\x44\x2\x2\x80"+
		"\x81\aG\x2\x2\x81\x85\a\x64\x2\x2\x82\x83\aG\x2\x2\x83\x85\a\x44\x2\x2"+
		"\x84|\x3\x2\x2\x2\x84~\x3\x2\x2\x2\x84\x80\x3\x2\x2\x2\x84\x82\x3\x2\x2"+
		"\x2\x85 \x3\x2\x2\x2\x86\x87\ag\x2\x2\x87\x8F\ay\x2\x2\x88\x89\ag\x2\x2"+
		"\x89\x8F\aY\x2\x2\x8A\x8B\aG\x2\x2\x8B\x8F\ay\x2\x2\x8C\x8D\aG\x2\x2\x8D"+
		"\x8F\aY\x2\x2\x8E\x86\x3\x2\x2\x2\x8E\x88\x3\x2\x2\x2\x8E\x8A\x3\x2\x2"+
		"\x2\x8E\x8C\x3\x2\x2\x2\x8F\"\x3\x2\x2\x2\x90\x91\t\x6\x2\x2\x91$\x3\x2"+
		"\x2\x2\x92\x93\ai\x2\x2\x93\x9B\au\x2\x2\x94\x95\ai\x2\x2\x95\x9B\aU\x2"+
		"\x2\x96\x97\aI\x2\x2\x97\x9B\au\x2\x2\x98\x99\aI\x2\x2\x99\x9B\aU\x2\x2"+
		"\x9A\x92\x3\x2\x2\x2\x9A\x94\x3\x2\x2\x2\x9A\x96\x3\x2\x2\x2\x9A\x98\x3"+
		"\x2\x2\x2\x9B&\x3\x2\x2\x2\x9C\x9D\ai\x2\x2\x9D\xA1\a\x33\x2\x2\x9E\x9F"+
		"\aI\x2\x2\x9F\xA1\a\x33\x2\x2\xA0\x9C\x3\x2\x2\x2\xA0\x9E\x3\x2\x2\x2"+
		"\xA1(\x3\x2\x2\x2\xA2\xA3\ai\x2\x2\xA3\xA7\a\x34\x2\x2\xA4\xA5\aI\x2\x2"+
		"\xA5\xA7\a\x34\x2\x2\xA6\xA2\x3\x2\x2\x2\xA6\xA4\x3\x2\x2\x2\xA7*\x3\x2"+
		"\x2\x2\xA8\xA9\ai\x2\x2\xA9\xAD\a\x35\x2\x2\xAA\xAB\aI\x2\x2\xAB\xAD\a"+
		"\x35\x2\x2\xAC\xA8\x3\x2\x2\x2\xAC\xAA\x3\x2\x2\x2\xAD,\x3\x2\x2\x2\xAE"+
		"\xAF\ai\x2\x2\xAF\xB3\a\x36\x2\x2\xB0\xB1\aI\x2\x2\xB1\xB3\a\x36\x2\x2"+
		"\xB2\xAE\x3\x2\x2\x2\xB2\xB0\x3\x2\x2\x2\xB3.\x3\x2\x2\x2\xB4\xB5\t\a"+
		"\x2\x2\xB5\x30\x3\x2\x2\x2\xB6\xB7\t\b\x2\x2\xB7\x32\x3\x2\x2\x2\xB8\xB9"+
		"\t\t\x2\x2\xB9\x34\x3\x2\x2\x2\xBA\xBB\an\x2\x2\xBB\xC3\ay\x2\x2\xBC\xBD"+
		"\aN\x2\x2\xBD\xC3\ay\x2\x2\xBE\xBF\an\x2\x2\xBF\xC3\aY\x2\x2\xC0\xC1\a"+
		"N\x2\x2\xC1\xC3\aY\x2\x2\xC2\xBA\x3\x2\x2\x2\xC2\xBC\x3\x2\x2\x2\xC2\xBE"+
		"\x3\x2\x2\x2\xC2\xC0\x3\x2\x2\x2\xC3\x36\x3\x2\x2\x2\xC4\xC5\t\n\x2\x2"+
		"\xC5\x38\x3\x2\x2\x2\xC6\xC7\t\v\x2\x2\xC7:\x3\x2\x2\x2\xC8\xC9\t\f\x2"+
		"\x2\xC9<\x3\x2\x2\x2\xCA\xCB\at\x2\x2\xCB\xD3\a\x66\x2\x2\xCC\xCD\at\x2"+
		"\x2\xCD\xD3\a\x46\x2\x2\xCE\xCF\aT\x2\x2\xCF\xD3\a\x66\x2\x2\xD0\xD1\a"+
		"T\x2\x2\xD1\xD3\a\x46\x2\x2\xD2\xCA\x3\x2\x2\x2\xD2\xCC\x3\x2\x2\x2\xD2"+
		"\xCE\x3\x2\x2\x2\xD2\xD0\x3\x2\x2\x2\xD3>\x3\x2\x2\x2\xD4\xD5\t\r\x2\x2"+
		"\xD5@\x3\x2\x2\x2\xD6\xD7\au\x2\x2\xD7\xDF\a\x64\x2\x2\xD8\xD9\au\x2\x2"+
		"\xD9\xDF\a\x44\x2\x2\xDA\xDB\aU\x2\x2\xDB\xDF\a\x64\x2\x2\xDC\xDD\aU\x2"+
		"\x2\xDD\xDF\a\x44\x2\x2\xDE\xD6\x3\x2\x2\x2\xDE\xD8\x3\x2\x2\x2\xDE\xDA"+
		"\x3\x2\x2\x2\xDE\xDC\x3\x2\x2\x2\xDF\x42\x3\x2\x2\x2\xE0\xE1\t\xE\x2\x2"+
		"\xE1\x44\x3\x2\x2\x2\xE2\xE3\av\x2\x2\xE3\xEB\a\x64\x2\x2\xE4\xE5\av\x2"+
		"\x2\xE5\xEB\a\x44\x2\x2\xE6\xE7\aV\x2\x2\xE7\xEB\a\x64\x2\x2\xE8\xE9\a"+
		"V\x2\x2\xE9\xEB\a\x44\x2\x2\xEA\xE2\x3\x2\x2\x2\xEA\xE4\x3\x2\x2\x2\xEA"+
		"\xE6\x3\x2\x2\x2\xEA\xE8\x3\x2\x2\x2\xEB\x46\x3\x2\x2\x2\xEC\xED\at\x2"+
		"\x2\xED\xF5\a\x64\x2\x2\xEE\xEF\at\x2\x2\xEF\xF5\a\x44\x2\x2\xF0\xF1\a"+
		"T\x2\x2\xF1\xF5\a\x64\x2\x2\xF2\xF3\aT\x2\x2\xF3\xF5\a\x44\x2\x2\xF4\xEC"+
		"\x3\x2\x2\x2\xF4\xEE\x3\x2\x2\x2\xF4\xF0\x3\x2\x2\x2\xF4\xF2\x3\x2\x2"+
		"\x2\xF5H\x3\x2\x2\x2\xF6\xF7\aw\x2\x2\xF7\xFF\a\x64\x2\x2\xF8\xF9\aw\x2"+
		"\x2\xF9\xFF\a\x44\x2\x2\xFA\xFB\aW\x2\x2\xFB\xFF\a\x64\x2\x2\xFC\xFD\a"+
		"W\x2\x2\xFD\xFF\a\x44\x2\x2\xFE\xF6\x3\x2\x2\x2\xFE\xF8\x3\x2\x2\x2\xFE"+
		"\xFA\x3\x2\x2\x2\xFE\xFC\x3\x2\x2\x2\xFFJ\x3\x2\x2\x2\x100\x101\az\x2"+
		"\x2\x101\x109\a\x66\x2\x2\x102\x103\az\x2\x2\x103\x109\a\x46\x2\x2\x104"+
		"\x105\aZ\x2\x2\x105\x109\a\x66\x2\x2\x106\x107\aZ\x2\x2\x107\x109\a\x46"+
		"\x2\x2\x108\x100\x3\x2\x2\x2\x108\x102\x3\x2\x2\x2\x108\x104\x3\x2\x2"+
		"\x2\x108\x106\x3\x2\x2\x2\x109L\x3\x2\x2\x2\x10A\x10B\az\x2\x2\x10B\x113"+
		"\ay\x2\x2\x10C\x10D\az\x2\x2\x10D\x113\aY\x2\x2\x10E\x10F\aZ\x2\x2\x10F"+
		"\x113\ay\x2\x2\x110\x111\aZ\x2\x2\x111\x113\aY\x2\x2\x112\x10A\x3\x2\x2"+
		"\x2\x112\x10C\x3\x2\x2\x2\x112\x10E\x3\x2\x2\x2\x112\x110\x3\x2\x2\x2"+
		"\x113N\x3\x2\x2\x2\x114\x115\t\xF\x2\x2\x115P\x3\x2\x2\x2\x116\x11A\x5"+
		";\x1E\x2\x117\x11B\x5\x33\x1A\x2\x118\x11B\x5\x1B\xE\x2\x119\x11B\x5\x39"+
		"\x1D\x2\x11A\x117\x3\x2\x2\x2\x11A\x118\x3\x2\x2\x2\x11A\x119\x3\x2\x2"+
		"\x2\x11BR\x3\x2\x2\x2\x11C\x127\x5\x37\x1C\x2\x11D\x128\x5\x19\r\x2\x11E"+
		"\x128\x5\x1D\xF\x2\x11F\x128\x5O(\x2\x120\x128\x5? \x2\x121\x128\x5\x1B"+
		"\xE\x2\x122\x128\x5#\x12\x2\x123\x128\x5\'\x14\x2\x124\x128\x5)\x15\x2"+
		"\x125\x128\x5+\x16\x2\x126\x128\x5-\x17\x2\x127\x11D\x3\x2\x2\x2\x127"+
		"\x11E\x3\x2\x2\x2\x127\x11F\x3\x2\x2\x2\x127\x120\x3\x2\x2\x2\x127\x121"+
		"\x3\x2\x2\x2\x127\x122\x3\x2\x2\x2\x127\x123\x3\x2\x2\x2\x127\x124\x3"+
		"\x2\x2\x2\x127\x125\x3\x2\x2\x2\x127\x126\x3\x2\x2\x2\x128T\x3\x2\x2\x2"+
		"\x129\x12B\x5\x17\f\x2\x12A\x129\x3\x2\x2\x2\x12A\x12B\x3\x2\x2\x2\x12B"+
		"\x12D\x3\x2\x2\x2\x12C\x12E\x5W,\x2\x12D\x12C\x3\x2\x2\x2\x12E\x12F\x3"+
		"\x2\x2\x2\x12F\x12D\x3\x2\x2\x2\x12F\x130\x3\x2\x2\x2\x130V\x3\x2\x2\x2"+
		"\x131\x132\t\x10\x2\x2\x132X\x3\x2\x2\x2\x133\x134\v\x2\x2\x2\x134Z\x3"+
		"\x2\x2\x2\x17\x2^\x84\x8E\x9A\xA0\xA6\xAC\xB2\xC2\xD2\xDE\xEA\xF4\xFE"+
		"\x108\x112\x11A\x127\x12A\x12F\x2";
	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN.ToCharArray());
}
} // namespace Spect.Net.CommandParser.Generated
