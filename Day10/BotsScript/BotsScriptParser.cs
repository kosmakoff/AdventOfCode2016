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
using Antlr4.Runtime.Tree;
using System.Collections.Generic;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.5.4-SNAPSHOT")]
[System.CLSCompliant(false)]
public partial class BotsScriptParser : Parser {
	public const int
		T__0=1, T__1=2, T__2=3, T__3=4, T__4=5, T__5=6, NEWLINE=7, WHITESPACE=8, 
		NUMBER=9;
	public const int
		RULE_program = 0, RULE_stmt = 1, RULE_botToDest = 2, RULE_valueToBot = 3, 
		RULE_value = 4, RULE_bot = 5, RULE_dest = 6, RULE_output = 7;
	public static readonly string[] ruleNames = {
		"program", "stmt", "botToDest", "valueToBot", "value", "bot", "dest", 
		"output"
	};

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

	public override string SerializedAtn { get { return _serializedATN; } }

	public BotsScriptParser(ITokenStream input)
		: base(input)
	{
		_interp = new ParserATNSimulator(this,_ATN);
	}
	public partial class ProgramContext : ParserRuleContext {
		public StmtContext[] stmt() {
			return GetRuleContexts<StmtContext>();
		}
		public StmtContext stmt(int i) {
			return GetRuleContext<StmtContext>(i);
		}
		public ProgramContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_program; } }
		public override void EnterRule(IParseTreeListener listener) {
			IBotsScriptListener typedListener = listener as IBotsScriptListener;
			if (typedListener != null) typedListener.EnterProgram(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IBotsScriptListener typedListener = listener as IBotsScriptListener;
			if (typedListener != null) typedListener.ExitProgram(this);
		}
	}

	[RuleVersion(0)]
	public ProgramContext program() {
		ProgramContext _localctx = new ProgramContext(_ctx, State);
		EnterRule(_localctx, 0, RULE_program);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 17;
			_errHandler.Sync(this);
			_la = _input.La(1);
			do {
				{
				{
				State = 16; stmt();
				}
				}
				State = 19;
				_errHandler.Sync(this);
				_la = _input.La(1);
			} while ( _la==T__3 || _la==T__4 );
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class StmtContext : ParserRuleContext {
		public ValueToBotContext valueToBot() {
			return GetRuleContext<ValueToBotContext>(0);
		}
		public ITerminalNode NEWLINE() { return GetToken(BotsScriptParser.NEWLINE, 0); }
		public BotToDestContext botToDest() {
			return GetRuleContext<BotToDestContext>(0);
		}
		public StmtContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_stmt; } }
		public override void EnterRule(IParseTreeListener listener) {
			IBotsScriptListener typedListener = listener as IBotsScriptListener;
			if (typedListener != null) typedListener.EnterStmt(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IBotsScriptListener typedListener = listener as IBotsScriptListener;
			if (typedListener != null) typedListener.ExitStmt(this);
		}
	}

	[RuleVersion(0)]
	public StmtContext stmt() {
		StmtContext _localctx = new StmtContext(_ctx, State);
		EnterRule(_localctx, 2, RULE_stmt);
		try {
			State = 27;
			switch (_input.La(1)) {
			case T__3:
				EnterOuterAlt(_localctx, 1);
				{
				State = 21; valueToBot();
				State = 22; Match(NEWLINE);
				}
				break;
			case T__4:
				EnterOuterAlt(_localctx, 2);
				{
				State = 24; botToDest();
				State = 25; Match(NEWLINE);
				}
				break;
			default:
				throw new NoViableAltException(this);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class BotToDestContext : ParserRuleContext {
		public DestContext low;
		public DestContext high;
		public BotContext bot() {
			return GetRuleContext<BotContext>(0);
		}
		public ITerminalNode[] WHITESPACE() { return GetTokens(BotsScriptParser.WHITESPACE); }
		public ITerminalNode WHITESPACE(int i) {
			return GetToken(BotsScriptParser.WHITESPACE, i);
		}
		public DestContext[] dest() {
			return GetRuleContexts<DestContext>();
		}
		public DestContext dest(int i) {
			return GetRuleContext<DestContext>(i);
		}
		public BotToDestContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_botToDest; } }
		public override void EnterRule(IParseTreeListener listener) {
			IBotsScriptListener typedListener = listener as IBotsScriptListener;
			if (typedListener != null) typedListener.EnterBotToDest(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IBotsScriptListener typedListener = listener as IBotsScriptListener;
			if (typedListener != null) typedListener.ExitBotToDest(this);
		}
	}

	[RuleVersion(0)]
	public BotToDestContext botToDest() {
		BotToDestContext _localctx = new BotToDestContext(_ctx, State);
		EnterRule(_localctx, 4, RULE_botToDest);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 29; bot();
			State = 30; Match(WHITESPACE);
			State = 31; Match(T__0);
			State = 32; Match(WHITESPACE);
			State = 33; _localctx.low = dest();
			State = 34; Match(WHITESPACE);
			State = 35; Match(T__1);
			State = 36; Match(WHITESPACE);
			State = 37; _localctx.high = dest();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class ValueToBotContext : ParserRuleContext {
		public ValueContext value() {
			return GetRuleContext<ValueContext>(0);
		}
		public ITerminalNode[] WHITESPACE() { return GetTokens(BotsScriptParser.WHITESPACE); }
		public ITerminalNode WHITESPACE(int i) {
			return GetToken(BotsScriptParser.WHITESPACE, i);
		}
		public BotContext bot() {
			return GetRuleContext<BotContext>(0);
		}
		public ValueToBotContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_valueToBot; } }
		public override void EnterRule(IParseTreeListener listener) {
			IBotsScriptListener typedListener = listener as IBotsScriptListener;
			if (typedListener != null) typedListener.EnterValueToBot(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IBotsScriptListener typedListener = listener as IBotsScriptListener;
			if (typedListener != null) typedListener.ExitValueToBot(this);
		}
	}

	[RuleVersion(0)]
	public ValueToBotContext valueToBot() {
		ValueToBotContext _localctx = new ValueToBotContext(_ctx, State);
		EnterRule(_localctx, 6, RULE_valueToBot);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 39; value();
			State = 40; Match(WHITESPACE);
			State = 41; Match(T__2);
			State = 42; Match(WHITESPACE);
			State = 43; bot();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class ValueContext : ParserRuleContext {
		public IToken val;
		public ITerminalNode WHITESPACE() { return GetToken(BotsScriptParser.WHITESPACE, 0); }
		public ITerminalNode NUMBER() { return GetToken(BotsScriptParser.NUMBER, 0); }
		public ValueContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_value; } }
		public override void EnterRule(IParseTreeListener listener) {
			IBotsScriptListener typedListener = listener as IBotsScriptListener;
			if (typedListener != null) typedListener.EnterValue(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IBotsScriptListener typedListener = listener as IBotsScriptListener;
			if (typedListener != null) typedListener.ExitValue(this);
		}
	}

	[RuleVersion(0)]
	public ValueContext value() {
		ValueContext _localctx = new ValueContext(_ctx, State);
		EnterRule(_localctx, 8, RULE_value);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 45; Match(T__3);
			State = 46; Match(WHITESPACE);
			State = 47; _localctx.val = Match(NUMBER);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class BotContext : ParserRuleContext {
		public IToken id;
		public ITerminalNode WHITESPACE() { return GetToken(BotsScriptParser.WHITESPACE, 0); }
		public ITerminalNode NUMBER() { return GetToken(BotsScriptParser.NUMBER, 0); }
		public BotContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_bot; } }
		public override void EnterRule(IParseTreeListener listener) {
			IBotsScriptListener typedListener = listener as IBotsScriptListener;
			if (typedListener != null) typedListener.EnterBot(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IBotsScriptListener typedListener = listener as IBotsScriptListener;
			if (typedListener != null) typedListener.ExitBot(this);
		}
	}

	[RuleVersion(0)]
	public BotContext bot() {
		BotContext _localctx = new BotContext(_ctx, State);
		EnterRule(_localctx, 10, RULE_bot);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 49; Match(T__4);
			State = 50; Match(WHITESPACE);
			State = 51; _localctx.id = Match(NUMBER);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class DestContext : ParserRuleContext {
		public BotContext bot() {
			return GetRuleContext<BotContext>(0);
		}
		public OutputContext output() {
			return GetRuleContext<OutputContext>(0);
		}
		public DestContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_dest; } }
		public override void EnterRule(IParseTreeListener listener) {
			IBotsScriptListener typedListener = listener as IBotsScriptListener;
			if (typedListener != null) typedListener.EnterDest(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IBotsScriptListener typedListener = listener as IBotsScriptListener;
			if (typedListener != null) typedListener.ExitDest(this);
		}
	}

	[RuleVersion(0)]
	public DestContext dest() {
		DestContext _localctx = new DestContext(_ctx, State);
		EnterRule(_localctx, 12, RULE_dest);
		try {
			State = 55;
			switch (_input.La(1)) {
			case T__4:
				EnterOuterAlt(_localctx, 1);
				{
				State = 53; bot();
				}
				break;
			case T__5:
				EnterOuterAlt(_localctx, 2);
				{
				State = 54; output();
				}
				break;
			default:
				throw new NoViableAltException(this);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class OutputContext : ParserRuleContext {
		public IToken id;
		public ITerminalNode WHITESPACE() { return GetToken(BotsScriptParser.WHITESPACE, 0); }
		public ITerminalNode NUMBER() { return GetToken(BotsScriptParser.NUMBER, 0); }
		public OutputContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_output; } }
		public override void EnterRule(IParseTreeListener listener) {
			IBotsScriptListener typedListener = listener as IBotsScriptListener;
			if (typedListener != null) typedListener.EnterOutput(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IBotsScriptListener typedListener = listener as IBotsScriptListener;
			if (typedListener != null) typedListener.ExitOutput(this);
		}
	}

	[RuleVersion(0)]
	public OutputContext output() {
		OutputContext _localctx = new OutputContext(_ctx, State);
		EnterRule(_localctx, 14, RULE_output);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 57; Match(T__5);
			State = 58; Match(WHITESPACE);
			State = 59; _localctx.id = Match(NUMBER);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public static readonly string _serializedATN =
		"\x3\xAF6F\x8320\x479D\xB75C\x4880\x1605\x191C\xAB37\x3\v@\x4\x2\t\x2\x4"+
		"\x3\t\x3\x4\x4\t\x4\x4\x5\t\x5\x4\x6\t\x6\x4\a\t\a\x4\b\t\b\x4\t\t\t\x3"+
		"\x2\x6\x2\x14\n\x2\r\x2\xE\x2\x15\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3\x3"+
		"\x5\x3\x1E\n\x3\x3\x4\x3\x4\x3\x4\x3\x4\x3\x4\x3\x4\x3\x4\x3\x4\x3\x4"+
		"\x3\x4\x3\x5\x3\x5\x3\x5\x3\x5\x3\x5\x3\x5\x3\x6\x3\x6\x3\x6\x3\x6\x3"+
		"\a\x3\a\x3\a\x3\a\x3\b\x3\b\x5\b:\n\b\x3\t\x3\t\x3\t\x3\t\x3\t\x2\x2\x2"+
		"\n\x2\x2\x4\x2\x6\x2\b\x2\n\x2\f\x2\xE\x2\x10\x2\x2\x2:\x2\x13\x3\x2\x2"+
		"\x2\x4\x1D\x3\x2\x2\x2\x6\x1F\x3\x2\x2\x2\b)\x3\x2\x2\x2\n/\x3\x2\x2\x2"+
		"\f\x33\x3\x2\x2\x2\xE\x39\x3\x2\x2\x2\x10;\x3\x2\x2\x2\x12\x14\x5\x4\x3"+
		"\x2\x13\x12\x3\x2\x2\x2\x14\x15\x3\x2\x2\x2\x15\x13\x3\x2\x2\x2\x15\x16"+
		"\x3\x2\x2\x2\x16\x3\x3\x2\x2\x2\x17\x18\x5\b\x5\x2\x18\x19\a\t\x2\x2\x19"+
		"\x1E\x3\x2\x2\x2\x1A\x1B\x5\x6\x4\x2\x1B\x1C\a\t\x2\x2\x1C\x1E\x3\x2\x2"+
		"\x2\x1D\x17\x3\x2\x2\x2\x1D\x1A\x3\x2\x2\x2\x1E\x5\x3\x2\x2\x2\x1F \x5"+
		"\f\a\x2 !\a\n\x2\x2!\"\a\x3\x2\x2\"#\a\n\x2\x2#$\x5\xE\b\x2$%\a\n\x2\x2"+
		"%&\a\x4\x2\x2&\'\a\n\x2\x2\'(\x5\xE\b\x2(\a\x3\x2\x2\x2)*\x5\n\x6\x2*"+
		"+\a\n\x2\x2+,\a\x5\x2\x2,-\a\n\x2\x2-.\x5\f\a\x2.\t\x3\x2\x2\x2/\x30\a"+
		"\x6\x2\x2\x30\x31\a\n\x2\x2\x31\x32\a\v\x2\x2\x32\v\x3\x2\x2\x2\x33\x34"+
		"\a\a\x2\x2\x34\x35\a\n\x2\x2\x35\x36\a\v\x2\x2\x36\r\x3\x2\x2\x2\x37:"+
		"\x5\f\a\x2\x38:\x5\x10\t\x2\x39\x37\x3\x2\x2\x2\x39\x38\x3\x2\x2\x2:\xF"+
		"\x3\x2\x2\x2;<\a\b\x2\x2<=\a\n\x2\x2=>\a\v\x2\x2>\x11\x3\x2\x2\x2\x5\x15"+
		"\x1D\x39";
	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN.ToCharArray());
}
