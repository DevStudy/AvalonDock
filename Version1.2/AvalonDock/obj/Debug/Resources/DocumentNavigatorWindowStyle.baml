   M S B A M L   `   `   `  ����T  PAvalonDock, Version=1.2.2702.0, Culture=neutral, PublicKeyToken=85a1e0ada7ec13e4'clr-namespace:AvalonDock
AvalonDock  5      \ XPresentationFramework, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35  �� MergedDictionaries �� Source(    "AvalonDock.DocumentNavigatorWindow �� 
TargetType �� 	Resources   Key �� Property �� Value �� 
TargetType ��Name �� Triggers	 P� Property
 P� Value �� 
TargetName �� DataType$   AvalonDock.NavigatorWindowItem �� Orientation �� CornerRadius  ad:DockingManager / +ad:AvalonDockBrushes.DefaultBackgroundBrush j� 
AlignmentX j� 
AlignmentY j� Stretch !� Visual �� Path �� Mode J� BitmapEffect F� Color F� ShadowDepth �� Triggers � RowDefinitions �� RelativeSource O� 	GlowColor O� GlowSize ��Name  listContentTemplate  listItemStyle! �� IsDeferredScrollingEnabled  listBoxStyle �� SelectedItem�� 5      F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     8x,http://schemas.microsoft.com/winfx/2006/xaml    5      adclr-namespace:AvalonDock  5        5      �� 5   
   $2 ,/AvalonDock;component/Resources/Brushes.xaml?�6   �� 5   
   $1 +/AvalonDock;component/Resources/Common.xaml?�6   %	  '         7  7  7  �� 5      "   6    5   
   ���� 5      listItemStyle  " ��6*   .�5      ��  � �� 5      �� 5      " ��6*   .R�5      �� $ 	extBorder��6%   ._�5   "   �� $��0,2,0,2q�63   5       5      P� 5   "   	 �@��
IsSelected
 . . �5   &   �� $ 	extBorder��6C   # � ��6Z    � ��5   #   5      5      5      �� 5      listBoxStyle  " ��6)   .�5       ��  � �� 5!      �� 5"      " ��6*   .R�5#      �� .��5$   "   �� 5%      5&      5(      5)      �� 5+      listContentTemplate  "  67   .R�5,      �� $ Vertical=�5-      $��Center=�5.      $��5q�5/      .+�53      �� $ 	intBorder��6   $ 2��6!   $��1q�62   ._�54      �� $��1q�6   
�������$��Right=�6�   $	��200��6�   $	��200��6�   $��5q�6�   ��6:   C� *�� *M� *3 +�� *3 +++._�55   	   �� ��56   
   !� 57      $
 Left=�6   $	 Top=�6)   $ Uniform=�6:    6L   �� $ ItemContent.Content�$ OneWay=�59   
    5:   	   F� 5;   
   $ DarkGray��6!   $ 4Q�62   5=   	   5>      �� 5@      $��Center=�6   $��0,4,0,0q�6.   ��6?   �� $ Title�5B       5C      P� 5D      	 �@J�IsMouseOver
 . . �5E      �� $ 	intBorder��68   # � ��6O    � ���� 5F      $ 	intBorder��67   # � ��6N    � ��5G      5J      5K      .�5L   
   ��  � �� 5M      �� 5N      "   6"   .R�5O      � .+�5P      �� $��1q�5Q      
�������$ 5��5S      ��5T      C� *�� *M� *3 +�� *3 +++._�5V      �  5W      �� 5X   "   $��20 �60   �� 5Y   "   $��* �60   .+�5[   
   �� $��20(�5]   !   $��Center=�5^   !   $��Center=�5_   !   $��0��5`   !   ��5\   !   ��  �� *TemplatedParent+$ SelectedContent.Title� 5b      O� 5c      $ White��6"   $ 10Q�64   5f      �� 5g      $ PART_ScrollingPanel��5h   	   $��1��5i   !   8��  8�� $
��Auto=�5n   !   $��Disabled=�5o   	    . 8�� ��5j   !   ��  �� *TemplatedParent+$ 	Documents� 5m   !   ��  �� *TemplatedParent+$ SelectedContent�$ TwoWay=���5s   "   �� 5t   &   .R�5u   *   � 5v   '   5x      5z      5{      5|      5}      5      5�      5�      