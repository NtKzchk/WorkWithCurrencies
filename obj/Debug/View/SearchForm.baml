   M S B A M L   `   `   `  ????J  FTest_Assignment, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:Test_Assignment.ViewTest_Assignment.View  5   	   %    Test_Assignment.View.SearchForm   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4local"clr-namespace:Test_Assignment.View     5   	     ? Title$  
SearchForm??5   	   $	??300??6   $	??800??6)   .??5	      ?  ? RowDefinitions 5
   
   ?? 5      $
??0.3* ?6   6,   ?? 5      $
??0.3* ?6   6,   ?? 5      6   ?? 5      $
??0.5* ?6   6,   .+?5   
   ?? $??Center=?6      	TextStyle#??[  61   VTYou can search for a currency by name or by code and get detailed information on it.6?   ?? 5   
   $??1??6   $??Center=?6!   $??20(?6>   #??[  6L   Enter one of the values.6?   ? 5   
   $??2??6    5      ?? 5      6"   ?? 5      6"    ? ColumnDefinitions 5      ?? 5      6%   ?? 5      6%   .+?5      ?? $??24(?6   $??Center=?6"   $??Center=?6?   .??6a   Enter currency code (ID)6{   ?? 5      $??1??6   $??24(?6$   $??Center=?62   $??Center=?6O   .??6q   Enter currency name6?   ?? 5      $??1??6   $??Center=?6$     ComboBoxStyle#??[ 6H   $??Center=?6o   $??24(?6?    ?? DisplayMemberPath$ Id??6?   ??6?   ?? *
Currencies+ ?? SelectedItem 6?   ?? *SelectedCurrency+6  ?? 5      $??1??6   $??Center=?6$   $??1??6H   #??[ 6X   $??Center=?6   $
 Name??6?   ??6?   ?? *
Currencies+ 6?   ?? *SelectedCurrency+6
  5      ?? 5    
   $??3??6   $??250 10 250 10q?6   ??65   ?? *OpenDetailsCommand+.??6\   	Details6e   5!      5"      