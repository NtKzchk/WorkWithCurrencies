   M S B A M L   `   `   `  ????J  FTest_Assignment, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:Test_Assignment.ViewTest_Assignment.View  5   	   *    $Test_Assignment.View.ConvertCurrency   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4local"clr-namespace:Test_Assignment.View     5   	     ? Title$  ConvertCurrency??5   	   $	??200??6!   $	??900??6.   .??5	      ?  ? ColumnDefinitions 5
   
   ?? 5      6!   ?? 5      6!   ?? 5      6!   ?? 5      6!   .+?5   
   ?? $??30(?6   $??Center=?6    $??Center=?6D   $??
50 45 0 45q?6f   $??Ink Free)?6z   ??6?   ?? *Sum+ ?? UpdateSourceTrigger$ PropertyChanged=? ?? Mode$ OneWayToSource=?6?   ?? 5   
   $??1??6      ComboBoxStyle#??[  6#   $??
0 45 50 45q?6J    ?? DisplayMemberPath$ Symbol??6?   ??6^   ?? *
Currencies+ ?? SelectedItem 6?   ?? *SelectedCurrencySum+6?   ?? 5   
   $??2??6   $??30(?6"   $??Center=?60   $??Center=?6T   $??Ink Free)?6v   $??
50 45 0 45q?6?    ?? 
IsReadOnly . ??6?   ?? *Result+$ PropertyChanged=?6?   ?? 5   
   $??3??6   #??[  6#   $??
0 45 50 45q?6J   $ Symbol??6?   ??6^   ?? *
Currencies+ 6?   ?? *SelectedCurrencyResult+6?   5      5      