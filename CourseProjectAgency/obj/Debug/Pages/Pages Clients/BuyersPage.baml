   M S B A M L   `   `   `  ����N  JCourseProjectAgency, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:CourseProjectAgencyCourseProjectAgency  5      $    CourseProjectAgency.BuyersPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      V RMaterialDesignThemes.Wpf, Version=3.1.1.1361, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      -local!clr-namespace:CourseProjectAgency  5        N� Title$  
BuyersPage��5
       � 	Resources 5         	ShowPopup �� 
TargetName �� TargetProperty R� KeyTime  System.Windows.Visibility   Visible R� Value   	Collapsed9  3System.Windows.Media.Animation.EasingDoubleKeyFrame O� KeyTime	 O� Value
 g� 	BeginTime p� KeyTime p� Value��%�  &	        �� 5   
   .��5      T� $ popupMessageGrid��6,   $ 
Visibility�5      ..�5      i� $ 0:0:0��6)   # Z 69   i� 5      $ 0:0:1.5��6)   # Z 6;   5      U� 5      $ (UIElement.Opacity)�6,   $ popupMessageGrid��6\   .\�5        $ 0:0:0.5��6'   $		 0.8Q�69     5      $ 0:0:1��6'   $
	 0.79Q�67     5      $ 0:0:1.5��6'   $	 0Q�69   5      r� 5      $ Margin�6/   $ popupMessageGrid��6R   $
 00:00:00X�6{   .	�5      �� $ 00:00:00��6*   $ 0, -55, 0, 0q�6=   �� 5      $ 	00:00:0.5��6*   $ 0, -50, 0, 0q�6>   �� 5      $ 00:00:1��6*   $ 0, -50, 0, 0q�6<   �� 5      $ 	00:00:1.5��6*   $ 0, -55, 0, 0q�6>   5      5      5      .��5!      � 
������� � RowDefinitions 5#   
   �� 5$      �� 5%      $��40 �6   �� 5&      $��60 �6   .+�5)   
   � -   5         �Name$ popupMessageGrid��5)       J� Opacity$ 0Q�6    K� ZIndex$ 1��65   $y�	Collapsed=�6F   .+�5*      �� $	��150��6   $��45��6!   $��Right=�6-   $	��Top=�6I   $��0, -55, 10, 0q�6a    �� CornerRadius$ 3��6x   ���	#FF4D1B7A._�5,      �� -   5         ��Name$ popupMessage��5,      $��Center=�62   $��Center=�6M   $��
0, 0, 0, 0q�6j   $��My Text��6~   
�������$��12(�6�   $
��Bold"�6�   5-      5.      &   System.Windows.Controls.DataGrid  50   
   -   5          Name$ 
BuyersGrid��50         AutoGenerateColumns .     HorizontalGridLinesBrush
 �   �   RowBackground
 �����   AlternatingRowBackground �	#FFA7A2B4$��0��51   M      
IsReadOnly .  
�������$��5q�6�      Columns 52      0  *System.Windows.Controls.DataGridTextColumn  53      ,  &System.Windows.Controls.DataGridColumn   Header$0 *ФИО клиента-покупателя��6B      Width5  /System.Windows.Controls.DataGridLengthConverter$	 40* 6c   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� *
FIObuyer+6c     54      $ Дата рождения��6C   $	 20* 6[    6%   �� *	BirthDate+6[     55      $! Домашний адрес��6A   $	 45* 6Y    6%   �� *	Address+6Y     56      $ Телефон��6?   $	 20* 6P    6%   �� *Phone+6P   58        5:   
   -   5        $ BuyersGrid2��5:      $y�	Collapsed=�6(    .  
 �   �
 ����� �	#FFA7A2B4$��0��5;   M    .  
�������$��5q�6�    5<        5=      $0 *ФИО клиента-покупателя��6B   $	 40* 6c    6%   �� *
FIObuyer+6c     5>      $ Дата рождения��6C   $	 20* 6[    6%   �� *	BirthDate+6[     5?      $! Домашний адрес��6A   $	 45* 6Y    6%   �� *	Address+6Y     5@      $ Телефон��6?   $	 20* 6P    6%   �� *Phone+6P   5B      � 5D   
   $��1��6   .+�5E      ��  �� Orientation$ 
Horizontal=�6   $��Right=�62   $��Center=�6N   $��0 0 10 0q�6i   .+�5F      d� -   5        $��TBActive��5F       $  MaterialDesignSwitchToggleButton#��[ 60   6j   �� 5G      $>��8Только действующие покупатели��6   $��10 0 0 0q�6A   5H      5I      � 5K   
   $��2��6    � ColumnDefinitions 5L      �� 5M      $��3* �6#   �� 5N      $��3* �6#   �� 5O      $��3* �6#   .+�5R      �� -   5         ��Name$ ButtonAddBuyer��5R      ���	#FF4D1B7A  MaterialDesignRaisedButton#��[ 6[   $��0��6�   
�������  � ToolTip$:  4Добавить клиента-покупателя��6�   $
��Auto��6�   $��11q�6�   +  %MaterialDesignThemes.Wpf.ShadowAssist!   ShadowDepth$! Depth2=�6�   ��6D   Z� .��5S      �� $ 
Horizontal=�6   .+�5T      '	  !MaterialDesignThemes.Wpf.PackIcon	  " 	  Kind$" UserAdd=�6.   $��20��6=   $��20��6I   �� 5U      $��ДОБАВИТЬ��6    $��3,0,0,0q�60   5V      5W      �� 5Y      -   5        $ ButtonDeleteBuyer��5Y      ���	#FF4D1B7A#��[ 6^   $��1��6�   
�������$M  GУдалить выбранного клиента-покупателя��6�   $
��Auto��6�   $��11q�6�   $! Depth2=�6   ��6G   Z� .��5Z      �� $ 
Horizontal=�6   .+�5[      	  $" DeleteForever=�6.   $��20��6C   $��20��6O   �� 5\      $��УДАЛИТЬ��6    $��3,0,0,0q�6/   5]      5^      �� 5_      -   5        $ ButtonEditBuyer��5_      ���	#FF4D1B7A#��[ 6\   $��2��6�   
�������$Y  SРедактировать выбранного клиента-покупателя��6�   $
��Auto��6�   $��11q�6�   $! Depth2=�6  ��6E   Z� .��5`      �� $ 
Horizontal=�6   .+�5a      	  $" UserEdit=�6.   $��20��6>   $��20��6J   �� 5b      $ ��РЕДАКТИРОВАТЬ��6    $��3,0,0,0q�65   5c      5d      5f      5g      5h      