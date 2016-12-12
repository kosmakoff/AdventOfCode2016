grammar BotsScript;

program: stmt+;

stmt
    : valueToBot NEWLINE
    | botToDest NEWLINE;

botToDest : bot WHITESPACE 'gives low to' WHITESPACE low=dest WHITESPACE 'and high to' WHITESPACE high=dest ;

valueToBot : value WHITESPACE 'goes to' WHITESPACE bot ;

value
    : 'value' WHITESPACE val=NUMBER;

bot
    : 'bot' WHITESPACE id=NUMBER;

dest
    : bot | output;

output
    : 'output' WHITESPACE id=NUMBER;

NEWLINE
	: '\n';

WHITESPACE
	: '\u0020';

NUMBER
	: ('0'..'9')+;
