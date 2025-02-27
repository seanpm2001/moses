# -*- mode: python -*-

block_cipher = None


a = Analysis(['moses.py'],
             pathex=['.'],
             binaries=[],
             datas=[("swagger.yaml","."),
                    ("platforms","platforms"),
                    ("eulas","eulas"),
                    ("licenses","licenses"),
                    ("../.pyenv/lib/python3.9/site-packages/openapi_spec_validator/resources/schemas","openapi_spec_validator/resources/schemas"),
                    ("../.pyenv/lib/python3.9/site-packages/swagger_ui_bundle/vendor/swagger-ui-3.30.0","api/ui")],
             hiddenimports=[],
             hookspath=[],
             runtime_hooks=[],
             excludes=[],
             win_no_prefer_redirects=False,
             win_private_assemblies=False,
             cipher=block_cipher,
             noarchive=False)
pyz = PYZ(a.pure, a.zipped_data,
             cipher=block_cipher)
exe = EXE(pyz,
          a.scripts,
          [],
          exclude_binaries=True,
          name='moses',
          debug=False,
          bootloader_ignore_signals=False,
          strip=False,
          upx=True,
          console=True )
coll = COLLECT(exe,
               a.binaries,
               a.zipfiles,
               a.datas,
               strip=False,
               upx=True,
               name='moses-linux')
