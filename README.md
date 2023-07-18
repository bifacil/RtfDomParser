# RtfDomParser (a.k.a. DCSoft.RTF) 
**RtfDomParser** is an open source C# library for parsing **RTF** documents and generating RTF DOM Tree.

This is a fork from this project:

https://github.com/SourceCodeBackup/RtfDomParser/

I've added some basic support for "stylesheets".

This fork is able to parse RTF like this:

```
{\rtf1
{\fonttbl
  {\f0 Calibri;}
  {\f1\fcharset2 Symbol;}
}
{\colortbl;\red128\green128\blue128;\red46\green116\blue181;\red0\green0\blue255;\red255\green255\blue0;}
{\*\defchp \fs22}
{\*\defpap \sa278}
{\stylesheet
  {\ql Normal;}
  {\s1 Quote;}
  {\cs13 Code;}
  {\s3 H1;}
  {\s4 H2;}
  {\s5 H3;}
  {\s6 H4;}
  {\s7 H5;}
  {\s8 H6;}
  {\cs11 HighLight;}
  {\cs12 HTML;}
}
{\*\listtable
{\list\listtemplateid-1\listid1353470507
  {\listlevel\f1{\leveltext\leveltemplateid560950967 \'01\u183\'b7;}}}
}
{\*\listoverridetable
  {\listoverride\listid1353470507\ls1}
}



{\pard\s3 Titulo 1\par}
}
```
