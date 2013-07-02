Vs2013webformBug
================

Found a bug with parsing ascx in webforms. vs2013 only.
if you open this in vs2013 preview and run it you will get 
<$A$> rendered before the text
if you close vs2013 and open the exact same solution in vs2012 you will not get this strange semi html tag
