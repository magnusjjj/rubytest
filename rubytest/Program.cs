// See https://aka.ms/new-console-template for more information
using rubytest;

string loader = File.ReadAllText("Scripts/loader.rb");

Directory.SetCurrentDirectory("C:\\Users\\magnu\\Downloads\\pif\\InfiniteFusionGame");

Console.WriteLine("Hello, World!");
Rubyism.ruby_init();
Rubyism.ruby_script("Hello");
int test = 0;
Rubyism.rb_eval_string_protect(loader, ref test);
if(test != 0)
    Rubyism.rb_eval_string("puts $!");
Rubyism.ruby_finalize();