   M S B A M L   `   `   `  ����C  ?demoPORG, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:ProgTask1NewProgTask1New  5   	       ProgTask1New.DataView   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:ProgTask1New     5   	     � Title$  DataView��5   	   $	��450��6   $	��800��6'    � WindowStartupLocation$ CenterScreen=�63   .��5	      � -   5         �Name$ moduleInfoGB��5	      ���	#FF33BFAC.+�5
   
   �� -   5        $��
Add Module��5
      $
��Left=�6&   $��
10,365,0,0q�6A   $	��Top=�6U   $	��396��6m   $��44��6y   6�   �� 5   
   -   5        $
��Exit��5      $
��Left=�6    $��420,365,0,0q�6;   $	��Top=�6P   $	��362��6h   $��44��6t   6�   �� 5   
   -   5         ��Name$ moduleDataListView��5      $
��Left=�6.   $	��305��6I   $��	10,44,0,0q�6V   $	��Top=�6i   $	��243��6�   6�   �� 5   
   $+��%Please select a module for more info:��6   $
��Left=�6@   $��	10,10,0,0q�6[   $	��Top=�6n   $	��243��6�   �� 5   
   -   5        $��	Log Hours��5      $
��Left=�6%   $��626,319,0,0q�6@   $	��Top=�6U   $	��114��6m   $��30��6y   6�   �� 5   
   $%��Total number of hours required:��6   $
��Left=�6:   $��
550,65,0,0q�6U   $	��Top=�6i   $
��Bold"�6�   �� 5   
   -   5         ��Name$ totalHoursLBL��5      $��hours��6'   $
��Left=�67   $��
550,91,0,0q�6R   $	��Top=�6f   $��16(�6~   �� 5   
   $��Weekly hours required:��6   $
��Left=�61   $��550,131,0,0q�6L   $	��Top=�6a   $
��Bold"�6y   �� 5   
   -   5        $ weeklyHoursLBL��5      $��hours��6(   $
��Left=�68   $��550,157,0,0q�6S   $	��Top=�6h   $��16(�6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ logListView��5      $
��Left=�6(   $	��304��6C   $��
265,45,0,0q�6P   $	��Top=�6d   $	��280��6|   5      5      