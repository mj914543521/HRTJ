--内科1_体检状态 0-未检 1-已检
alter table tb_studentexam add column state_nk1 int 0;
-- 内科1_体检日期
alter table tb_studentexam add column updatetime_nk1 date null;
-- 内科2_体检状态 0-未检 1-已检
alter table tb_studentexam add column state_nk2 int 0;
-- 内科2_体检日期
alter table tb_studentexam add column updatetime_nk2 date null;

-- 外科1_体检状态 0-未检 1-已检
alter table tb_studentexam add column state_wk1 int 0;
-- 外科1_体检日期
alter table tb_studentexam add column updatetime_wk1 date null;

-- 外科2_体检状态 0-未检 1-已检
alter table tb_studentexam add column state_wk2 int 0;
-- 外科2_体检日期
alter table tb_studentexam add column updatetime_wk2 date null;

-- 眼科1_体检状态 0-未检 1-已检
alter table tb_studentexam add column state_yk1 int 0;
-- 眼科1_体检日期
alter table tb_studentexam add column updatetime_yk1 date null;

-- 眼科2_体检状态 0-未检 1-已检
alter table tb_studentexam add column state_yk2 int 0;
-- 眼科2_体检日期
alter table tb_studentexam add column updatetime_yk2 date null;

-- 检验科_体检状态 0-未检 1-已检
alter table tb_studentexam add column state_jyk int 0;
-- 检验科_体检日期
alter table tb_studentexam add column updatetime_jyk date null;

-- 口腔科_体检状态 0-未检 1-已检
alter table tb_studentexam add column state_kqk int 0;
-- 口腔科_体检日期
alter table tb_studentexam add column updatetime_kqk date null;

--内科1_体检状态 0-未检 1-已检
alter table tb_studentexam_Client add column state_nk1 int 0;
-- 内科1_体检日期
alter table tb_studentexam_Client add column updatetime_nk1 date null;
-- 内科2_体检状态 0-未检 1-已检
alter table tb_studentexam_Client add column state_nk2 int 0;
-- 内科2_体检日期
alter table tb_studentexam_Client add column updatetime_nk2 date null;

-- 外科1_体检状态 0-未检 1-已检
alter table tb_studentexam_Client add column state_wk1 int 0;
-- 外科1_体检日期
alter table tb_studentexam_Client add column updatetime_wk1 date null;

-- 外科2_体检状态 0-未检 1-已检
alter table tb_studentexam_Client add column state_wk2 int 0;
-- 外科2_体检日期
alter table tb_studentexam_Client add column updatetime_wk2 date null;

-- 眼科1_体检状态 0-未检 1-已检
alter table tb_studentexam_Client add column state_yk1 int 0;
-- 眼科1_体检日期
alter table tb_studentexam_Client add column updatetime_yk1 date null;

-- 眼科2_体检状态 0-未检 1-已检
alter table tb_studentexam_Client add column state_yk2 int 0;
-- 眼科2_体检日期
alter table tb_studentexam_Client add column updatetime_yk2 date null;

-- 检验科_体检状态 0-未检 1-已检
alter table tb_studentexam_Client add column state_jyk int 0;
-- 检验科_体检日期
alter table tb_studentexam_Client add column updatetime_jyk date null;

-- 口腔科_体检状态 0-未检 1-已检
alter table tb_studentexam_Client add column state_kqk int 0;
-- 口腔科_体检日期
alter table tb_studentexam_Client add column updatetime_kqk date null;
