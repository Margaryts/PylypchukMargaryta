   M S B A M L   `   `   `  ����F  BCourseWork2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:CourseWork2CourseWork2  5          CourseWork2.UserOrder   5      W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      +localclr-namespace:CourseWork2     5        N� Title$  	UserOrder��5	       N� 
Background �#F4F4F4.��5      � $��10q�6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   �� 5      $
��Auto �6   .+�5   
   �� $#��Ваші замовлення��6   $��24(�5      $
��Bold"�5      ���#333$��Center=�5      $��10q�5      &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ OrdersDataGrid��5         AutoGenerateColumns$
 True��6+   $��10q�6F   �� 5   
    �� Orientation$ 
Horizontal=�6   $��Right=�5      $��2��5       $��5q�5!      .+�5"      �� -   5        $+��%Видалити замовлення��5"      $	��120��63   $��10q�6?   $��Center=�6K   $��Bottom=�6h   5#      �� 5%      -   5        $!��Оновити список��5%      ���#2196F3
�������$	��8,4q�5)      $��5q�5*      $	��150��5+      5,      5-      5.      