   M S B A M L   `   `   `  ���� T  PAvalonDock, Version=1.2.2702.0, Culture=neutral, PublicKeyToken=85a1e0ada7ec13e4'clr-namespace:AvalonDock
AvalonDock  \ XPresentationFramework, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35  �� MergedDictionaries �� Source     AvalonDock.NavigatorWindow �� 
TargetType �� 	Resources   Key �� Property �� Value �� 
TargetType ��Name �� Triggers	 P� Property
 P� Value �� 
TargetName �� DataType$   AvalonDock.NavigatorWindowItem �� Orientation   AvalonDock.AlignedImage j� Stretch !� Visual �� Path �� CornerRadius �� 
StartPoint �� EndPoint � Color � Offset � Orientation �� RelativeSource �� Mode ��Name ��Name  listBoxStyle  listItemStyle  listContentTemplate �� SelectedItem �� SelectionMode �� Padding j� 
AlignmentX j� 
AlignmentY�� F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     8x,http://schemas.microsoft.com/winfx/2006/xaml    adclr-namespace:AvalonDock    �� $2 ,/AvalonDock;component/Resources/Brushes.xaml?��� $1 +/AvalonDock;component/Resources/Common.xaml?�%>	  '         7  7  7  7  7  7  �� "    ���� listItemStyle  " ��.���  � �� �� " ��.R��� $ 	intBorder��._��� $��0,2,0,2q� P� 	 �@J�IsMouseOver
 . . ��� $ 	intBorder��# � �� � ��P� 	 �@��
IsSelected
 . . ��� $ 	intBorder��# � �� � ���� listBoxStyle  " ��.���  � �� �� " ��.R��� .���� �� listContentTemplate  "  .R��� $ 
Horizontal=�$��Stretch=�
������ .+�  ._��� $��16��$��16����!� $
 None=� �� $
 Icon��� $��4,0,0,0q����� $ Title�.���  � �� �� "   .R��� $��1q�
�������$ 5��$	��440��$	��550������ $	 0,0&�$	 0,1&�.��� $ 	#FFFFFFFF��$ 0Q�� $ 	#FFCAD1FF��$ 1Q�._�� .+��� $��0,0,0,1q�$ 5,5,0,0��
�������$��60��$	��Top=����� $	 0,0&�$	 1,0&�.��� $ 	#FF0018C7��$ 0Q�� $ 	#FFA5B0FF��$ 1Q�._�� .+�� $��10q�$ 
Horizontal=�.+��� $��16��$��16����!� $
 None=� ��  �� *TemplatedParent+$&  SelectedContent.ItemContent.Icon�$ OneWay=��� $ title��$��5,0,0,0q�$��12(�$
��Bold"�
�����������  �� *TemplatedParent+$ SelectedContent.Title��� $��20, 35, 0, 0q�����  �� *TemplatedParent+$, &SelectedContent.ContentTypeDescription��� $ 
Horizontal=�$��20, 70, 230, 20q�.+��� $ Vertical=�.+��� $��Active Tool Windows��$��11(�$
��Bold"�
���   ��� $ ToolWindowsList��8��  8�� $��0,10,0,0q�8��  ��  �� *TemplatedParent+$ SelectedToolWindow�����  �� *TemplatedParent+$ DockableContents�� .+��� $ Vertical=�$��20,0,0,0q�.+��� $��Active Documents��$��11(�$
��Bold"�
���   ��� $ DocumentList��8�� 8�� $ Single=�$��0,10,0,0q�8�� $	��300�� ��  �� *TemplatedParent+$ SelectedContent�����  �� *TemplatedParent+$ 	Documents��� $��	0,50,20,0q�$��1q�
�������$��Right=�$	��250��$	��200��$ 4q�._��� ��!� $
 Left=�$	 Top=�$ Uniform=� ��  �� *TemplatedParent+$) #SelectedContent.ItemContent.Content�$ OneWay=��� $��0,0,0,1q�$ 0,0,5,5�����	#FFADD8E6
�������$��30��$��Bottom=�._��� $��20, 5, 0, 0q�$
��Wrap=�$��WordEllipsis=�����  �� *TemplatedParent+$ SelectedContent.InfoTip�