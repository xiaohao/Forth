// 键入 everyday tips 随机显示一句名言
include random.fs

: tips1 
       dup 1 = if page ." 人生应该如蜡烛一样，从顶燃到底，一直都是光明的。 —— 萧楚女 " drop 
  else dup 2 = if page ." 路是脚踏出来的，历史是人写出来的。人的每一步行动都在书写自己的历史。 —— 吉鸿昌 " drop 
  else dup 3 = if page ." 春蚕到死丝方尽，人至期颐亦不休。一息尚存须努力，留作青年好范畴。 —— 吴玉章  " drop 
  else dup 4 = if page ." 但愿每次回忆，对生活都不感到负疚 —— 郭小川 " drop 
  else dup 5 = if page ." 人的一生可能燃烧也可能腐朽，我不能腐朽，我愿意燃烧起来！ —— 奥斯特洛夫斯基  " drop 
  then then then then then  ; 
: tips2 
       dup 6 = if page ." 你若要喜爱你自己的价值，你就得给世界创造价值。 —— 歌德 " drop 
  else dup 7 = if page ." 社会犹如一条船，每个人都要有掌舵的准备。 —— 易卜生 " drop 
  else dup 8 = if page ." 人生不是一种享乐，而是一桩十分沉重的工作。 —— 列夫·托尔斯泰  " drop 
  else dup 9 = if page ." 生活只有在平淡无味的人看来才是空虚而平淡无味的。 —— 车尔尼雪夫斯基 " drop 
  else dup 10 = if page ." 一个人的价值，应该看他贡献什么，而不应当看他取得什么。 —— 爱因斯坦 " drop 
  then then then then then  ; 
: tips3 
       dup 11 = if page ." 人只有献身于社会，才能找出那短暂而有风险的生命的意义。 —— 爱因斯坦 " drop 
  else dup 12 = if page ." 生活真象这杯浓酒，不经三番五次的提炼呵，就不会这样可口！ —— 郭小川 " drop 
  else dup 13 = if page ." 充满着欢乐与斗争精神的人们，永远带着欢乐，欢迎雷霆与阳光。 —— 赫胥黎  " drop 
  else dup 14 = if page ." 希望是附丽于存在的，有存在，便有希望，有希望，便是光明。 —— 鲁迅 " drop 
  else dup 15 = if page ." 生活就是战斗。 —— 柯罗连科 " drop 
  then then then then then  ; 
: tips4 
       dup 16 = if page ." 沉沉的黑夜都是白天的前奏。 —— 郭小川  " drop 
  else dup 17 = if page ." 我们唯一不会改正的缺点是软弱。 —— 拉罗什福科  " drop 
  else dup 18 = if page ." 古之立大事者，不惟有超世之才，亦必有坚忍不拔之志。 —— 苏轼   " drop 
  else dup 19 = if page ." 生当作人杰，死亦为鬼雄，至今思项羽，不肯过江东。 —— 李清照  " drop 
  else dup 20 = if page ." 壮心未与年俱老，死去犹能作鬼雄。 —— 陆游  " drop 
  then then then then then  ; 
: tips5 
       dup 21 = if page ." 故立志者，为学之心也；为学者，立志之事也。 —— 王阳明  " drop 
  else dup 22 = if page ." 贫不足羞，可羞是贫而无志。 —— 吕坤  " drop 
  else dup 23 = if page ." 我们以人们的目的来判断人的活动。目的伟大，活动才可以说是伟大的。 —— 契诃夫  " drop 
  else dup 24 = if page ." 毫无理想而又优柔寡断是一种可悲的心理。 —— 培根 " drop 
  else dup 25 = if page ." 生活的理想，就是为了理想的生活。 —— 张闻天 " drop 
  then then then then then  ; 
: tips6 
       dup 26 = if page ." 人，只要有一种信念，有所追求，什么艰苦都能忍受，什么环境也都能适应。 —— 丁玲  " drop 
  else dup 27 = if page ." 我从来不把安逸和快乐看作是生活目的本身---这种伦理基础，我叫它猪栏的理想。 —— 爱因斯坦 " drop 
  else dup 28 = if page ." 理想的人物不仅要在物质需要的满足上，还要在精神旨趣的满足上得到表现。 —— 黑格尔 " drop 
  else dup 29 = if page ." 一个能思想的人，才真是一个力量无边的人。 —— 巴尔扎克  " drop 
  else dup 30 = if page ." 一个没有受到献身的热情所鼓舞的人，永远不会做出什么伟大的事情来。 —— 车尔尼雪夫斯基  " drop 
  else dup 31 = if page ." 共同的事业，共同的斗争，可以使人们产生忍受一切的力量。 —— 奥斯特洛夫斯基 " drop 
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

