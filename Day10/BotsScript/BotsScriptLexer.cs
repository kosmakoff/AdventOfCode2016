//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.5.4-SNAPSHOT
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from BotsScript.g4 by ANTLR 4.5.4-SNAPSHOT

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.5.4-SNAPSHOT")]
[System.CLSCompliant(false)]
public partial class BotsScriptLexer : Lexer {
	public const int
		T__0=1, T__1=2, T__2=3, T__3=4, T__4=5, T__5=6, NEWLINE=7, WHITESPACE=8, 
		NUMBER=9;
	public static string[] modeNames = {
		"DEFAULT_MODE"
	};

	public static readonly string[] ruleNames = {
		"T__0", "T__1", "T__2", "T__3", "T__4", "T__5", "NEWLINE", "WHITESPACE", 
		"NUMBER"
	};


	public BotsScriptLexer(ICharStream input)
		: base(input)
	{
		_interp = new LexerATNSimulator(this,_ATN);
	}

	private static readonly string[] _LiteralNames = {
		null, "'gives low to'", "'and high to'", "'goes to'", "'value'", "'bot'", 
		"'output'", "'\n'", "'\\u0020'"
	};
	private static readonly string[] _SymbolicNames = {
		null, null, null, null, null, null, null, "NEWLINE", "WHITESPACE", "NUMBER"
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

	[System.Obsolete]
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

	public override string GrammarFileName { get { return "BotsScript.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string[] ModeNames { get { return modeNames; } }

	public override string SerializedAtn { get { return _serializedATN; } }

	public static readonly string _serializedATN =
		"\x3\xAF6F\x8320\x479D\xB75C\x4880\x1605\x191C\xAB37\x2\vP\b\x1\x4\x2\t"+
		"\x2\x4\x3\t\x3\x4\x4\t\x4\x4\x5\t\x5\x4\x6\t\x6\x4\a\t\a\x4\b\t\b\x4\t"+
		"\t\t\x4\n\t\n\x3\x2\x3\x2\x3\x2\x3\x2\x3\x2\x3\x2\x3\x2\x3\x2\x3\x2\x3"+
		"\x2\x3\x2\x3\x2\x3\x2\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3"+
		"\x3\x3\x3\x3\x3\x3\x3\x3\x3\x4\x3\x4\x3\x4\x3\x4\x3\x4\x3\x4\x3\x4\x3"+
		"\x4\x3\x5\x3\x5\x3\x5\x3\x5\x3\x5\x3\x5\x3\x6\x3\x6\x3\x6\x3\x6\x3\a\x3"+
		"\a\x3\a\x3\a\x3\a\x3\a\x3\a\x3\b\x3\b\x3\t\x3\t\x3\n\x6\nM\n\n\r\n\xE"+
		"\nN\x2\x2\x2\v\x3\x2\x3\x5\x2\x4\a\x2\x5\t\x2\x6\v\x2\a\r\x2\b\xF\x2\t"+
		"\x11\x2\n\x13\x2\v\x3\x2\x2P\x2\x3\x3\x2\x2\x2\x2\x5\x3\x2\x2\x2\x2\a"+
		"\x3\x2\x2\x2\x2\t\x3\x2\x2\x2\x2\v\x3\x2\x2\x2\x2\r\x3\x2\x2\x2\x2\xF"+
		"\x3\x2\x2\x2\x2\x11\x3\x2\x2\x2\x2\x13\x3\x2\x2\x2\x3\x15\x3\x2\x2\x2"+
		"\x5\"\x3\x2\x2\x2\a.\x3\x2\x2\x2\t\x36\x3\x2\x2\x2\v<\x3\x2\x2\x2\r@\x3"+
		"\x2\x2\x2\xFG\x3\x2\x2\x2\x11I\x3\x2\x2\x2\x13L\x3\x2\x2\x2\x15\x16\a"+
		"i\x2\x2\x16\x17\ak\x2\x2\x17\x18\ax\x2\x2\x18\x19\ag\x2\x2\x19\x1A\au"+
		"\x2\x2\x1A\x1B\a\"\x2\x2\x1B\x1C\an\x2\x2\x1C\x1D\aq\x2\x2\x1D\x1E\ay"+
		"\x2\x2\x1E\x1F\a\"\x2\x2\x1F \av\x2\x2 !\aq\x2\x2!\x4\x3\x2\x2\x2\"#\a"+
		"\x63\x2\x2#$\ap\x2\x2$%\a\x66\x2\x2%&\a\"\x2\x2&\'\aj\x2\x2\'(\ak\x2\x2"+
		"()\ai\x2\x2)*\aj\x2\x2*+\a\"\x2\x2+,\av\x2\x2,-\aq\x2\x2-\x6\x3\x2\x2"+
		"\x2./\ai\x2\x2/\x30\aq\x2\x2\x30\x31\ag\x2\x2\x31\x32\au\x2\x2\x32\x33"+
		"\a\"\x2\x2\x33\x34\av\x2\x2\x34\x35\aq\x2\x2\x35\b\x3\x2\x2\x2\x36\x37"+
		"\ax\x2\x2\x37\x38\a\x63\x2\x2\x38\x39\an\x2\x2\x39:\aw\x2\x2:;\ag\x2\x2"+
		";\n\x3\x2\x2\x2<=\a\x64\x2\x2=>\aq\x2\x2>?\av\x2\x2?\f\x3\x2\x2\x2@\x41"+
		"\aq\x2\x2\x41\x42\aw\x2\x2\x42\x43\av\x2\x2\x43\x44\ar\x2\x2\x44\x45\a"+
		"w\x2\x2\x45\x46\av\x2\x2\x46\xE\x3\x2\x2\x2GH\a\f\x2\x2H\x10\x3\x2\x2"+
		"\x2IJ\a\"\x2\x2J\x12\x3\x2\x2\x2KM\x4\x32;\x2LK\x3\x2\x2\x2MN\x3\x2\x2"+
		"\x2NL\x3\x2\x2\x2NO\x3\x2\x2\x2O\x14\x3\x2\x2\x2\x4\x2N\x2";
	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN.ToCharArray());
}