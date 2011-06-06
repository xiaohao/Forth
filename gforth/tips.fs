// 键入 everyday tips 随机显示一句名言
include random.fs
: tips1 
       dup 1 = if page ." ����Ӧ��������һ�����Ӷ�ȼ���ף�һֱ���ǹ����ġ� ���� ����Ů " drop 
  else dup 2 = if page ." ·�ǽ�̤�����ģ���ʷ����д�����ġ��˵�ÿһ���ж�������д�Լ�����ʷ�� ���� ������ " drop 
  else dup 3 = if page ." ���ϵ���˿���������������಻�ݡ�һϢ�д���Ŭ�������������÷��롣 ���� ������  " drop 
  else dup 4 = if page ." ��Ըÿ�λ��䣬��������е����� ���� ��С�� " drop 
  else dup 5 = if page ." �˵�һ������ȼ��Ҳ���ܸ��࣬�Ҳ��ܸ��࣬��Ը��ȼ�������� ���� ��˹������˹��  " drop 
  then then then then then  ; 
: tips2 
       dup 6 = if page ." ����Ҫϲ�����Լ��ļ�ֵ�����͵ø����紴����ֵ�� ���� ���� " drop 
  else dup 7 = if page ." ��������һ������ÿ���˶�Ҫ���ƶ���׼���� ���� �ײ��� " drop 
  else dup 8 = if page ." ��������һ�����֣�����һ׮ʮ�ֳ��صĹ����� ���� �з����ж�˹̩  " drop 
  else dup 9 = if page ." ����ֻ����ƽ����ζ���˿������ǿ�����ƽ����ζ�ġ� ���� ������ѩ��˹�� " drop 
  else dup 10 = if page ." һ���˵ļ�ֵ��Ӧ�ÿ�������ʲô������Ӧ������ȡ��ʲô�� ���� ����˹̹ " drop 
  then then then then then  ; 
: tips3 
       dup 11 = if page ." ��ֻ�����������ᣬ�����ҳ��Ƕ��ݶ��з��յ����������塣 ���� ����˹̹ " drop 
  else dup 12 = if page ." ���������ⱭŨ�ƣ������������ε������ǣ��Ͳ��������ɿڣ� ���� ��С�� " drop 
  else dup 13 = if page ." �����Ż����붷�����������ǣ���Զ���Ż��֣���ӭ���������⡣ ���� ������  " drop 
  else dup 14 = if page ." ϣ���Ǹ����ڴ��ڵģ��д��ڣ�����ϣ������ϣ�������ǹ����� ���� ³Ѹ " drop 
  else dup 15 = if page ." ��������ս���� ���� �������� " drop 
  then then then then then  ; 
: tips4 
       dup 16 = if page ." �����ĺ�ҹ���ǰ�����ǰ�ࡣ ���� ��С��  " drop 
  else dup 17 = if page ." ����Ψһ����������ȱ���������� ���� ����ʲ����  " drop 
  else dup 18 = if page ." ��֮�������ߣ���Ω�г���֮�ţ������м��̲���֮־�� ���� ����   " drop 
  else dup 19 = if page ." �������˽ܣ�����Ϊ���ۣ�����˼���𣬲��Ϲ������� ���� ������  " drop 
  else dup 20 = if page ." ׳��δ�������ϣ���ȥ���������ۡ� ���� ½��  " drop 
  then then then then then  ; 
: tips5 
       dup 21 = if page ." ����־�ߣ�Ϊѧ֮��Ҳ��Ϊѧ�ߣ���־֮��Ҳ�� ���� ������  " drop 
  else dup 22 = if page ." ƶ�����ߣ�������ƶ����־�� ���� ����  " drop 
  else dup 23 = if page ." ���������ǵ�Ŀ�����ж��˵Ļ��Ŀ��ΰ�󣬻�ſ���˵��ΰ���ġ� ���� ��ڭ��  " drop 
  else dup 24 = if page ." �����������������Ѷ���һ�ֿɱ��������� ���� ���� " drop 
  else dup 25 = if page ." ���������룬����Ϊ����������� ���� ������ " drop 
  then then then then then  ; 
: tips6 
       dup 26 = if page ." �ˣ�ֻҪ��һ���������׷����ʲô���඼�����ܣ�ʲô����Ҳ������Ӧ�� ���� ����  " drop 
  else dup 27 = if page ." �Ҵ������Ѱ��ݺͿ��ֿ���������Ŀ�ı���---���������������ҽ������������롣 ���� ����˹̹ " drop 
  else dup 28 = if page ." ���������ﲻ��Ҫ��������Ҫ�������ϣ���Ҫ�ھ���ּȤ�������ϵõ����֡� ���� �ڸ��� " drop 
  else dup 29 = if page ." һ����˼�����ˣ�������һ�������ޱߵ��ˡ� ���� �Ͷ�����  " drop 
  else dup 30 = if page ." һ��û���ܵ��������������������ˣ���Զ��������ʲôΰ������������ ���� ������ѩ��˹��  " drop 
  else dup 31 = if page ." ��ͬ����ҵ����ͬ�Ķ���������ʹ���ǲ�������һ�е������� ���� ��˹������˹�� " drop 
  then then then then then then ; 
: everyday 31 random ; 
: tips 
       dup 0  > swap dup 6  < rot and if tips1 
  else dup 5  > swap dup 11 < rot and if tips2 
  else dup 10 > swap dup 16 < rot and if tips3 
  else dup 15 > swap dup 21 < rot and if tips4 
  else dup 20 > swap dup 26 < rot and if tips5 
  else dup 25 > swap dup 32 < rot and if tips6 
  then then then then then then ; 

