   M S B A M L   `   `   `  ����G  CDailyProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:DailyProject.DayDailyProject.Day  5      %    DailyProject.Day.DailyWritePage   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      0localclr-namespace:DailyProject.Day     5      -   5          N� 
FontFamily$  Meiryo)�5       N� FontSize$ 18(�5	       N� Title$ 	DailyPage��5       J� InputBindings 5      �� 5   
    �� Command$  ��6    �� 	Modifiers$
 Ctrlf�6    
 �� Key$ S��61   .��5      � ���	#FF323232.+�5   
   �� .��5      �� $��10,10,10,10q�6   .+�5      �� -   5        $��----年--月--日��5      
�������$��Center=�6B   $��36(�6_   $
��Bold"�6m   $��Meiryo)�6   6�   �� 5       J� Opacity$ 0Q�6   $��10��6(   �� 5      -   5        .��5   &   Save6,   �� 5      $ 0Q�6   $��10��6(   �� 5      $��今週の目標��6   
�������6)   �� 5      $�� - TextBlock��6   $
��Wrap=�61   
����������	#FF141414$��60��6o    �� Padding$ 5,5,5,5q�6~   $��18(�6�   �� 5      $ 0Q�6   $��10��6(   �� 5      $��MissionStatement��6   
�������64   �� 5      $�� - TextBlock��6   $
��Wrap=�61   
����������	#FF141414$��60��6o   $ 5,5,5,5q�6~   �� 5      $ 0Q�6   $��10��6(   �� 5!      $!��昨日のよかったこと��6   
�������6-   �� 5"      	 �� TextWrapping$
	 Wrap=�6g   
����������	#FF141414
 �� AcceptsReturn$

 True��6�   $��60��6�   $��5,5,5,5q�6�   ��6   �� *	GoodPoint+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�6�   �� 5#      $ 0Q�6   $��10��6(   �� 5%      $!��昨日の変えたいこと��6   
�������6-   �� 5&      $
	 Wrap=�6i   
����������	#FF141414$

 True��6�   $��60��6�   $��5,5,5,5q�6�   ��6   �� *ChangePoint+$ TwoWay=�$ PropertyChanged=�6�   �� 5'      $ 0Q�6   $��10��6(   �� 5)      $��本日の約束��6   
�������6)   �� 5*      $
	 Wrap=�6d   
����������	#FF141414$

 True��6�   $��60��6�   $��5,5,5,5q�6�   ��6   �� *Target+$ TwoWay=�$ PropertyChanged=�6�   �� 5+      $ 0Q�6   $��10��6(   5,      5-      5.      5/      