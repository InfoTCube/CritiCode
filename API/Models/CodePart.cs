namespace API.Models;

public class CodePart
{
    public int Id { get; set; }
    public string? Description { get; set; }
    public string? Code { get; set; }
    public ProgrammingLanguage Language { get; set; }
    public ICollection<Review>? Reviews { get; set; }
}

public enum ProgrammingLanguage
{
    CSharp,
    Java,
    Python,
    JavaScript,
    TypeScript,
    C,
    CPlusPlus,
    Ruby,
    Go,
    Swift,
    Kotlin,
    Rust,
    PHP,
    HTML,
    CSS,
    R,
    MATLAB,
    Lua,
    Haskell,
    Perl,
    ObjectiveC,
    Dart,
    Scala,
    FSharp,
    Elixir,
    Groovy,
    SQL,
    ShellScript,
    VisualBasic,
    COBOL,
    Assembly,
    Julia,
    VHDL,
    Verilog,
    Tcl,
    ActionScript,
    CoffeeScript,
    Smalltalk,
    Hack,
    Crystal,
    Nim
}