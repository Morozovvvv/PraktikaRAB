   M S B A M L   `   `   `  ����G  CPrakticka2.0, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:Prakticka2._0Prakticka2._0  5   	       Prakticka2._0.Cheni   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:Prakticka2._0     5   	   -   5          � Title$  Cheni��5   	   $��277.661��6   $��365.608��6(    � WindowStyle$
 None=�6Q    � AllowsTransparency .  � 	Resources 5	          Prakticka2._0.loginDataSet   loginDataSet  chenaViewSource �� Source �� Source��%V   &	        &	      7     5
   
   6   �� 5   
    67   �� *Chena+8   5      .��5      � $
��Left=�6   $	��278��6&   $	��Top=�63   $	��837��6K    � DataContext# [ 6W   $��
0,0,-471,0q�6�   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ chenaDataGrid��5         AutoGenerateColumns .  	   EnableRowVirtualization	 . 
   RowDetailsVisibilityMode$
 VisibleWhenSelected=�6}   $��
0,10,470,0q�6�   ��6e   ��    Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      -   5        mashinaColumn��,  &System.Windows.Controls.DataGridColumn   Header$ Mashina��5   X      Width5  /System.Windows.Controls.DataGridLengthConverter$	 100 6i   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6<   �� *	Mashina+6i     5      -   5        chenaColumn��$ Chena��5   T   $	 100 6c    6:   �� *Chena+6c     5      -   5        
reisColumn��$
 Reis��5   R   $	 100 6`    69   �� *Reis+6`   5      �� 5   
   -   5        $	��←��5      $
��Left=�6   $��	311,9,0,0q�68   $	��Top=�6K   $��56��6c   $��24��6�   $��16(�6�   
�������6�   �� 5   
   -   5        
���   �$��1q�5   %   $
��Left=�69   $��10��6T   $	��Top=�6`   $	��367��6x   ���	#FF31D4746�   5      5      