   M S B A M L   `   `   `  ����T  PAvalonDock, Version=1.2.2702.0, Culture=neutral, PublicKeyToken=85a1e0ada7ec13e4'clr-namespace:AvalonDock
AvalonDock  5      \ XPresentationFramework, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35  �� MergedDictionaries �� Source     AvalonDock.NavigatorWindow �� 
TargetType �� 	Resources   Key �� Property �� Value �� 
TargetType ��Name �� Triggers	 P� Property
 P� Value �� 
TargetName �� DataType$   AvalonDock.NavigatorWindowItem �� Orientation   AvalonDock.AlignedImage j� Stretch !� Visual �� Path �� CornerRadius �� 
StartPoint �� EndPoint � Color � Offset � Orientation �� RelativeSource �� Mode ��Name ��Name  listBoxStyle  listItemStyle  listContentTemplate �� SelectedItem �� SelectionMode �� Padding j� 
AlignmentX j� 
AlignmentY�� 5      F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     8x,http://schemas.microsoft.com/winfx/2006/xaml    5      adclr-namespace:AvalonDock  5        5      �� 5   
   $2 ,/AvalonDock;component/Resources/Brushes.xaml?�6   �� 5   
   $1 +/AvalonDock;component/Resources/Common.xaml?�6   %�  '         7  7  7  7  7  7  �� 5      "   6    5   
   ���� 5      listItemStyle  " ��6*   .�5      ��  � �� 5      �� 5      " ��6*   .R�5      �� $ 	intBorder��6%   ._�5      �� $��0,2,0,2q�6/   5       5      P� 5   "   	 �@J�IsMouseOver
 . . �5   &   �� $ 	intBorder��6C   # � ��6Z    � ��5   #   P� 5   "   	 �@��
IsSelected
 . . �5   &   �� $ 	intBorder��6C   # � ��6Z    � ��5   #   5      5      5       �� 5"      listBoxStyle  " ��6)   .�5#      ��  � �� 5$      �� 5%      " ��6*   .R�5&      �� .��5'      �� 5(      5)      5+      5,      �� 5.      listContentTemplate  "  67   .R�5/      �� $ 
Horizontal=�6   $��Stretch=�66   
������ .+�50        ._�51      �� $��16��6   $��16��6   ��52   	   !� 53   
   $
 None=�6    6%   �� $
 Icon�55   	   56      �� 57      $��4,0,0,0q�6    ��61   �� $ Title�59      5:      5<      .�5=   
   ��  � �� 5>      �� 5?      "   6"   .R�5@      �� $��1q�6   
�������$ 5��6H   $	��440��6Y   $	��550��6f   ��5A      �� 5B      $	 0,0&�62   $	 0,1&�6C   .��5C   "   � $ 	#FFFFFFFF��6/   $ 0Q�6A   � 5D   "   $ 	#FFCAD1FF��6/   $ 1Q�6A   5E      ._�5G      � .+�5H      �� $��0,0,0,1q�6%   $ 5,5,0,0��6?   
�������$��60��6m   $	��Top=�6y   ��5I   "   �� 5J   &   $	 0,0&�6:   $	 1,0&�6K   .��5K   *   � $ 	#FF0018C7��67   $ 0Q�6I   � 5L   *   $ 	#FFA5B0FF��67   $ 1Q�6I   5M   '   ._�5O   "   � .+�5P   &   � $��10q�60   $ 
Horizontal=�6<   .+�5R   *   �� $��16��61   $��16��6<   ��5S   .   !� 5T   2   $
 None=�6>    6M   ��  �� *TemplatedParent+$&  SelectedContent.ItemContent.Icon�$ OneWay=�5V   +   �� 5W   *   $ title��64   $��5,0,0,0q�6�   $��12(�6�   $
��Bold"�6�   
���������6C   ��  �� *TemplatedParent+$ SelectedContent.Title�6�   5X   '   �� 5Y   &   $��20, 35, 0, 0q�60   ��6F   ��  �� *TemplatedParent+$, &SelectedContent.ContentTypeDescription�5Z   #   5[      �� 5]      $ 
Horizontal=�6)   $��20, 70, 230, 20q�6B   .+�5^   "   �� $ Vertical=�6-   .+�5_   &   �� $��Active Tool Windows��60   $��11(�6K   $
��Bold"�6Y   
���   �6k   �� 5`   &   $ ToolWindowsList��5a   )   8��  8�� $��0,10,0,0q�5d   )   8��  5e   )   ��  �� *TemplatedParent+$ SelectedToolWindow���5f   )   ��  �� *TemplatedParent+$ DockableContents�5g   )   5i   #   � 5j   "   .+�5k   "   �� $ Vertical=�6-   $��20,0,0,0q�6D   .+�5l   &   �� $��Active Documents��60   $��11(�6H   $
��Bold"�6V   
���   �6h   �� 5m   &   $ DocumentList��5n   +   8�� 8�� $ Single=�5q   +   $��0,10,0,0q�5r   +   8�� $	��300��5v   +    5s   +   ��  �� *TemplatedParent+$ SelectedContent���5t   +   ��  �� *TemplatedParent+$ 	Documents�5x   '   5z   #   5{   #   5|      �� 5~      $��	0,50,20,0q�6%   $��1q�68   
�������$��Right=�6c   $	��250��6   $	��200��6�   $ 4q�6�   ._�5   "   �� ��5�   &   !� 5�   *   $
 Left=�66   $	 Top=�6H   $ Uniform=�6Y    6k   ��  �� *TemplatedParent+$) #SelectedContent.ItemContent.Content�$ OneWay=�5�   #   5�      �� 5�      $��0,0,0,1q�6%   $ 0,0,5,5��6?   ���	#FFADD8E6
�������$��30��6�   $��Bottom=�6�   ._�5�   "   �� $��20, 5, 0, 0q�6,   $
��Wrap=�6�   $��WordEllipsis=�6�   ��6A   ��  �� *TemplatedParent+$ SelectedContent.InfoTip�6�   5�      5�      5�      5�      5�      5�      5�      